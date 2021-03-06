using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace WHC.Framework.BaseUI.Settings
{
	public class PropertyPage : BaseUserControl
	{
		private System.ComponentModel.Container components = null;

        /// <summary>
        /// 是否已经初始化
        /// </summary>
        public bool IsInit { get; set; }
	
        /// <summary>
        /// 初始化函数
        /// </summary>
		public PropertyPage()
		{
			InitComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		private void InitComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		#region Overridables

        /// <summary>
        /// 控件文本显示
        /// </summary>
		public new virtual string Text
		{
			get { return this.GetType().Name; }
		}

        /// <summary>
        /// 控件图片对象
        /// </summary>
		public virtual Image Image
		{
			get { return null; }
		}

        /// <summary>
        /// 初始化代码
        /// </summary>
		public virtual void OnInit()
		{
			this.IsInit = true;
		}

        /// <summary>
        /// 页面激活的处理
        /// </summary>
		public virtual void OnSetActive()
		{
		}

        /// <summary>
        /// 保存数据事件
        /// </summary>
        /// <returns></returns>
		public virtual bool OnApply()
		{
            return true;
		}


		#endregion
	}
}
