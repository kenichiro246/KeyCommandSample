using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KeyCommandSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// キーボード入力値を受け取る。
        /// </summary>
        /// <param name="value"></param>
        public void SetKeyboardValue(string value)
        {
            Label1.Text = value;
        }
    }
}
