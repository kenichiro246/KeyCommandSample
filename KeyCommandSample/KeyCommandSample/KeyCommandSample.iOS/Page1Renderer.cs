using Foundation;
using KeyCommandSample.iOS;
using ObjCRuntime;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(KeyCommandSample.Page1), typeof(Page1Renderer))]
namespace KeyCommandSample.iOS
{
    public class Page1Renderer : PageRenderer
    {
        private string _RecvValue = string.Empty;

        public override bool CanBecomeFirstResponder
        {
            get { return true; }
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            string key = string.Empty;
            var selector = new Selector("KeyRecv:");
            for (int i = 0; i <= 127; i++)
            {
                key = ((char)i).ToString();
                UIKeyCommand accelerator1 = UIKeyCommand.Create((NSString)key, 0, selector);
                AddKeyCommand(accelerator1);
                UIKeyCommand acceleratorShift = UIKeyCommand.Create((NSString)key, UIKeyModifierFlags.Shift, selector);
                AddKeyCommand(acceleratorShift);
            }
            UIKeyCommand accelerator2 = UIKeyCommand.Create((NSString)"\n", 0, selector);
            AddKeyCommand(accelerator2);
            UIKeyCommand accelerator3 = UIKeyCommand.Create((NSString)"\r", 0, selector);
            AddKeyCommand(accelerator3);
        }

        [Export("KeyRecv:")]
        public void KeyRecv(UIKeyCommand cmd)
        {
            if (cmd == null)
                return;
            var inputValue = cmd.Input;
            if (inputValue == "\n" || inputValue == "\r")
            {
                SetKeyboardValue(_RecvValue);
                _RecvValue = string.Empty;
            }
            else
            {
                _RecvValue += inputValue;
            }
        }
        public void SetKeyboardValue(string value)
        {
            ((KeyCommandSample.Page1)Element)?.SetKeyboardValue(value);
        }
    }
}
