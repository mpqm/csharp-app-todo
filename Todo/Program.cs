using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Config;
using Todo.DB;
namespace Todo
{
    internal static class Program
    {

        [ThreadStatic()]
        private static SingletonForms s_singletonForms;
        internal static SingletonForms Forms => s_singletonForms ??= new SingletonForms();
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBConnection.Initialize(); // DB 연결 초기화
            Application.Run(Forms.TodoForm);
        }
    }
}
