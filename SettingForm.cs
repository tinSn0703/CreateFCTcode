using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFCTcode
{
	/// <summary>アプリのフォーム上の設定</summary>
	public class SettingForm : Setting
	{
		//--------------------------------------------------------------------------------------------------//
		// field
		//--------------------------------------------------------------------------------------------------//

		private ApplicatonMode _Mode = new ApplicatonMode();

		//--------------------------------------------------------------------------------------------------//
		// method
		//--------------------------------------------------------------------------------------------------//
		/// <summary>コンストラクタ</summary>
		public SettingForm() { this.SetDafultSetting(); }

		//--------------------------------------------------------------------------------------------------//
		/// <summary>設定データにデフォルトの設定を入力する</summary>
		public override void SetDafultSetting()
		{
			this.InputFilePath = "";
			this.OutputFilePath = "";
			this.ReferenceFilePath = "";
			this.ModeName = this.Mode.DEFAULT_MODE_NAME;
		}

		//--------------------------------------------------------------------------------------------------//
		// property
		//--------------------------------------------------------------------------------------------------//
		/// <summaryフォーム上の設定の要素名</summary>
		public override string SettingName => "Form";

		/// <summary>実行アプリケーションモード</summary>
		public ApplicatonMode Mode => _Mode;

		/// <summary>入力ファイルパス</summary>
		public string InputFilePath { get; set; }

		/// <summary>出力ファイルパス</summary>
		public string OutputFilePath { get; set; }

		/// <summary>参照ファイルパス</summary>
		public string ReferenceFilePath { get; set; }

		/// <summary>実行アプリケーションモード名</summary>
		public string ModeName { get; set; }
	}
}