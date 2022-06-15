using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreateFCTcode
{
	/// <summary>XMLの設定ファイルから、フォーム上の設定を読み出す方法を表す</summary>
	public class SettingProcessXmlForm : SettingProcessXml
	{
		//--------------------------------------------------------------------------------------------------//
		// field
		//--------------------------------------------------------------------------------------------------//

		private const string SETTING_ATTRIBUTE_NAME_INPUT = "input";
		private const string SETTING_ATTRIBUTE_NAME_OUTPUT = "output";
		private const string SETTING_ATTRIBUTE_NAME_REFERENCE = "reference";
		private const string SETTING_ATTRIBUTE_NAME_MODE = "mode";

		private SettingForm _SettingForm;

		//--------------------------------------------------------------------------------------------------//
		// method
		//--------------------------------------------------------------------------------------------------//
		/// <summary>コンストラクタ</summary>
		public SettingProcessXmlForm()
		{
			this._SettingForm = null;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>コンストラクタ</summary>
		/// <param name="_Obj">本クラスで操作する設定データ</param>
		public SettingProcessXmlForm(in Setting _Obj)
		{
			this.SetSetting(_Obj ?? throw new ArgumentNullException(nameof(_Obj)));
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>コンストラクタ</summary>
		/// <param name="_Obj">本クラスで操作する設定データ</param>
		public SettingProcessXmlForm(in SettingForm _Obj)
		{
			this.SetSetting(_Obj ?? throw new ArgumentNullException(nameof(_Obj)));
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary></summary>
		/// <param name="_Obj">本クラスで操作する設定データ</param>
		public override void SetSetting(in Setting _Obj)
		{
			if (_Obj is null) throw new ArgumentNullException(nameof(_Obj));
			if (!(_Obj is SettingForm)) throw new ArgumentException("Invalid type inputed. Input type: [" + _Obj.GetType().Name + "].", nameof(_Obj));

			this._SettingForm = _Obj as SettingForm;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary></summary>
		/// <param name="_Obj">本クラスで操作する設定データ</param>
		public void SetSetting(in SettingForm _Obj)
		{
			this._SettingForm = _Obj ?? throw new ArgumentNullException(nameof(_Obj));
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>設定データをXML要素に変換する</summary>
		/// <returns>フォーム上の設定要素</returns>
		public override XElement ReadElement()
		{
			if (_SettingForm is null) throw new InvalidOperationException("[" + nameof(_SettingForm) + "] is undefined.");
			if (!_SettingForm.Mode.ModeList.Contains(_SettingForm.ModeName)) _SettingForm.ModeName = _SettingForm.Mode.DEFAULT_MODE_NAME;

			return new XElement(this.SettingName,
				new XAttribute(SETTING_ATTRIBUTE_NAME_INPUT, _SettingForm.InputFilePath),
				new XAttribute(SETTING_ATTRIBUTE_NAME_OUTPUT, _SettingForm.OutputFilePath),
				new XAttribute(SETTING_ATTRIBUTE_NAME_REFERENCE, _SettingForm.ReferenceFilePath),
				new XAttribute(SETTING_ATTRIBUTE_NAME_MODE, _SettingForm.ModeName)
			);
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>XML要素を元に、設定データを入力する</summary>
		/// <param name="_Element">フォーム上の設定要素</param>
		public override void WriteElement(in XElement _Element)
		{
			if (_SettingForm is null) throw new InvalidOperationException("[" + nameof(_SettingForm) + "] is undefined.");
			if (_Element is null) throw new ArgumentNullException(nameof(_Element));

			var _Attribute = _Element.Attribute(SETTING_ATTRIBUTE_NAME_INPUT);
			_SettingForm.InputFilePath = ((_Attribute is null) ? "" : (System.IO.File.Exists(_Attribute.Value) ? _Attribute.Value : ""));

			_Attribute = _Element.Attribute(SETTING_ATTRIBUTE_NAME_OUTPUT);
			_SettingForm.OutputFilePath = ((_Attribute is null) ? "" : (System.IO.File.Exists(_Attribute.Value) ? _Attribute.Value : ""));

			_Attribute = _Element.Attribute(SETTING_ATTRIBUTE_NAME_REFERENCE);
			_SettingForm.ReferenceFilePath = ((_Attribute is null) ? "" : (System.IO.File.Exists(_Attribute.Value) ? _Attribute.Value : ""));

			_Attribute = _Element.Attribute(SETTING_ATTRIBUTE_NAME_MODE);
			_SettingForm.ModeName = ((_Attribute is null) ? _SettingForm.Mode.DEFAULT_MODE_NAME : (_SettingForm.Mode.ModeList.Contains(_Attribute.Value) ? _Attribute.Value : _SettingForm.Mode.DEFAULT_MODE_NAME));
		}

		//--------------------------------------------------------------------------------------------------//
		// property
		//--------------------------------------------------------------------------------------------------//
		/// <summary>設定データクラスを返す</summary>
		public override Setting Setting => _SettingForm;

		/// <summaryフォーム上の設定の要素名</summary>
		public override string SettingName => _SettingForm.SettingName;
	}
}
