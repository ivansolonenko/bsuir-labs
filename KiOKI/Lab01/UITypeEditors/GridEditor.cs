using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Lab01.Cryptography;
using Lab01.Forms;

namespace Lab01.UITypeEditors
{
	internal class GridEditor : CollectionEditor
	{
		public GridEditor(Type type) : base(type) { }

		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			// ReSharper disable once PossibleNullReferenceException
			var svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
			var result = value as bool[][];
			if (svc != null)
			{
				using (var form = new GridEditorForm())
				{
					form.GridSize = CryptoManager.Instance.Settings.GridSize;

					if (svc.ShowDialog(form) == DialogResult.OK)
					{
						result = form.GetGrid();
					}
				}
			}
			// ReSharper disable once AssignNullToNotNullAttribute
			return result;
		}

		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}
	}
}
