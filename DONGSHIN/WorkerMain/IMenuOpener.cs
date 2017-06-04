using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DONGSHIN.WorkerMain
{
    public interface IMenuOpener
    {
        void OpenNewForm(Form newForm);
        void OpenDefaultContent();
    }
}
