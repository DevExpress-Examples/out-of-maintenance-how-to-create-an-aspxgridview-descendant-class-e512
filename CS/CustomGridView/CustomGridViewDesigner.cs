using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Web.ASPxGridView.Design;
using DevExpress.Web.ASPxGridView;

namespace CustomGridView {
    [ToolboxItem(false)]
    public class CustomGridViewDesigner : GridViewDesigner {
        public override void Initialize(IComponent component) {
            base.Initialize(component);
            RegisterTagPrefix(typeof(ASPxGridView));
        }
    }
}
