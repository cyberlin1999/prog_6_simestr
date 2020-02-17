//----------------------------------------------
// InheritTheWin.cs (c) 2005 by Charles Petzold
//----------------------------------------------
using System;
using System.Windows;
using System.Windows.Input;

namespace Petzold.InheritTheWin
{
    class InheritTheWin : Window//создание класса  
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();//создание нового обЪекта типа Application
            app.Run(new InheritTheWin());//выполнение метода run и создание класса "окон"
        }
        public InheritTheWin()
        {
            Title = "Inherit the Win";//извенение свойтсва заголовок окна
        }
    }
}