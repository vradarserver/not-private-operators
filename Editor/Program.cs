using System;
using System.Text;
using System.Windows.Forms;

namespace Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitialiseUnhandledExceptionHandling();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EditorForm());
        }

        static void InitialiseUnhandledExceptionHandling()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            ShowException(e.Exception);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if(ex != null) {
                ShowException(ex);
            } else {
                MessageBox.Show($"An exception that was not of type Exception was caught.\r\n{e.ExceptionObject}", "Unknown Exception Caught");
            }
        }

        static void ShowException(Exception ex)
        {
            var buffer = new StringBuilder();
            buffer.AppendFormat($"An unhandled exception was caught: {ex.Message}{Environment.NewLine}Full message:{ex.ToString()}{Environment.NewLine}");
            for(var innerEx = ex.InnerException;innerEx != null;innerEx = innerEx.InnerException) {
                buffer.AppendFormat($"{Environment.NewLine}INNER EXCEPTION: {innerEx.Message}{Environment.NewLine}{innerEx.ToString()}{Environment.NewLine}");
            }

            var message = buffer.ToString();

            try {
                Clipboard.SetText(message);
            } catch {}

            try {
                MessageBox.Show(message, "Unhandled Exception Caught");
            } catch {}
        }
    }
}
