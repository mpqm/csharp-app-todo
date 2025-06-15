using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo.Config
{
    /// <summary>
    /// 폼들을 싱글톤(Singleton) 방식으로 관리하는 클래스
    /// 한 번 생성된 폼은 재사용하고, 필요한 경우에만 생성됨
    /// </summary>
    internal class SingletonForms
    {
        // 현재 생성 중인 폼 타입들을 추적하기 위한 ThreadStatic 변수 (재귀 생성 방지용)
        [ThreadStatic]
        private static HashSet<Type> s_formBeingCreated;

        /// <summary>
        /// 제네릭 타입 T에 대한 폼 인스턴스를 생성
        /// 재귀 생성(폼 생성 중 폼을 다시 생성하는 상황)을 방지
        /// </summary>
        private static T CreateInstance<T>() where T : Form, new()
        {
            // 폼 생성 중에 또 생성하려는 경우 예외 발생
            if ((s_formBeingCreated ??= new HashSet<Type>()).Contains(typeof(T)))
                throw new InvalidOperationException("WinForms_RecursiveFormCreate");

            s_formBeingCreated.Add(typeof(T));

            try
            {
                return new T(); // 실제 폼 생성
            }
            catch (TargetInvocationException ex) when (ex.InnerException is not null)
            {
                // 생성 중 예외 발생 시, 내포된 예외를 던짐
                throw new InvalidOperationException(ex.InnerException.Message, ex.InnerException);
            }
            finally
            {
                // 생성 완료 후 타입 제거
                s_formBeingCreated.Remove(typeof(T));
            }
        }

        /// <summary>
        /// 폼 인스턴스를 Dispose하고 null로 초기화
        /// </summary>
        private static void DisposeInstance<T>(ref T instance) where T : Form
        {
            instance.Dispose();
            instance = null;
        }

        /// <summary>
        /// 폼 인스턴스를 설정할 때 기존 인스턴스와 다르면 예외 발생
        /// null로만 설정할 수 있도록 제한
        /// </summary>
        private static void SetInstance<T>(T value, ref T instance) where T : Form
        {
            if (ReferenceEquals(value, instance))
                return;

            if (value is not null)
                throw new ArgumentException("Property can only be set to null");

            DisposeInstance(ref instance);
        }

        // SingletonForms 타입 반환 (object의 GetType 오버라이드 방지)
        internal new Type GetType() => typeof(SingletonForms);

        // Memo 폼에 대한 싱글톤 인스턴스 보관용 변수
        private TodoForm m_todoForm;

        /// <summary>
        /// Memo 폼에 대한 싱글톤 속성
        /// 필요할 때만 생성되고 이후 재사용됨
        /// </summary>
        public TodoForm TodoForm
        {
            get => m_todoForm ??= CreateInstance<TodoForm>(); // 없으면 생성
            set => SetInstance(value, ref m_todoForm);    // 외부에서 null로만 설정 가능
        }
    }
}
