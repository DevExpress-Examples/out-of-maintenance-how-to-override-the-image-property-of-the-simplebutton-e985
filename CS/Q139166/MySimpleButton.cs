using DevExpress.XtraEditors;
using System.Reflection;

namespace DXSample {
    public class MySimpleButton : SimpleButton {
        public MySimpleButton() : base() { }

        public override System.Drawing.Image Image {
            get { return base.Image; }
            set {
                if (base.Image == value) return;
                FieldInfo fi = typeof(SimpleButton).GetField("image", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(this, value);
                OnPropertiesChanged();
            }
        }

        protected override DevExpress.XtraEditors.ViewInfo.BaseStyleControlViewInfo CreateViewInfo() { return new MySimpleButtonViewInfo(this); }
    }
}