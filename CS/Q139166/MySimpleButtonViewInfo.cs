using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Reflection;
using DevExpress.Utils;
namespace DXSample {
    public class MySimpleButtonViewInfo : SimpleButtonViewInfo {
        public MySimpleButtonViewInfo(SimpleButton owner) : base(owner) { }

        protected override EditorButtonObjectInfoArgs CreateEditorButtonObjectInfoArgs(EditorButton editorButton, AppearanceObject appearance) {
            return base.CreateEditorButtonObjectInfoArgs(new MyEditorButton(), appearance);
        }
    }

    public class MyEditorButton : EditorButton {
        public MyEditorButton() : base() { }

        public override System.Drawing.Image Image {
            get { return base.Image; }
            set {
                if (base.Image == value) return;
                FieldInfo fi = typeof(EditorButton).GetField("_image", BindingFlags.Instance | BindingFlags.NonPublic);
                fi.SetValue(this, value);
                OnChanged();
            }
        }
    }
}