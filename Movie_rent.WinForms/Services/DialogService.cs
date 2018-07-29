using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_rent.WinForms.Services
{
    public class DialogService
    {
        private static bool? ConvertDialogResult(DialogResult result)
        {
            switch (result)
            {
                case DialogResult.OK:
                case DialogResult.Yes:
                    return true;
                case DialogResult.No:
                    return false;
                default:
                    return null;
            }
        }
    }

    public class DialogResponse
    {
        private readonly bool? _dialogResult;

        protected DialogResponse(bool? dialogResult)
        {
            _dialogResult = dialogResult;
        }
        public bool IsOk { get { return _dialogResult == true; } }
        public bool IsCancel { get { return _dialogResult == null; } }
        public bool IsNo { get { return _dialogResult == false; } }
    }
}
