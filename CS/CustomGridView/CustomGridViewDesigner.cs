using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxGridView.Design;
using System.Windows.Forms;

namespace CustomGridView {
    [ToolboxItem(false)]
    public class CustomGridViewDesigner : GridViewDesigner {
        public override void Initialize(IComponent component) {
            base.Initialize(component);
            RegisterTagPrefix(typeof(ASPxGridView));
        }
    }
}
