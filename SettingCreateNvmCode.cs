using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFCTcode
{
	class SettingCreateNvmCode : Setting.Setting
	{
		//--------------------------------------------------------------------------------------------------//
		// method
		//--------------------------------------------------------------------------------------------------//
		/// <summary>コンストラクタ</summary>
		public SettingCreateNvmCode() { this.SetDafultSetting(); }

		//--------------------------------------------------------------------------------------------------//
		/// <summary>設定データにデフォルトの設定を入力する</summary>
		public override void SetDafultSetting()
		{
			this.NvmFilePass = "";
			this.OutputDirectory = "";
			this.SendCommand = "MFTX";
			this.RamCommand = "K06";
			this.Comment = "";
			this.BeginWriteAddress = 0;
			this.EndWriteAddress = 65635;
			this.MinWriteByteNum = 0;
			this.MaxWriteByteNum = 64;
			this.MaxWriteBlockNum = 4;
			this.IsReverseAddress = true;
	}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>NVMデータファイルのパスを設定する</summary>
		/// <param name="_pass"></param>
		/// <returns></returns>
		public bool SetNvmFilePass(string _pass)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>結果を保存するファイルへのディレクトリを設定する</summary>
		/// <param name="_pass"></param>
		/// <returns></returns>
		public bool SetOutputDirectory(string _pass)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>NVMデータ書き込みを行うRSコマンドを設定する</summary>
		public bool SetSendCommand(string _command)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>NVMデータ書き込みを行うRAMモニタコマンドを設定する</summary>
		public bool SetRamCommand(string _command)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>コメントを設定する</summary>
		public bool SetComment(string _comment)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>書き込みを行う先頭アドレス番号(0x0000~0xffffまで)を設定する</summary>
		public bool SetBeginWriteAddress(int _num)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>書き込みを行う末尾アドレス番号(0x0000~0xffffまで)を設定する</summary>
		public bool SetEndWriteAddress(int _num)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>書き込みコマンドで一度に書き込めるアドレスの最小バイト数を設定する</summary>
		public bool SetMinWriteByteNum(Int16 _num)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>書き込みコマンドで一度に書き込めるアドレスの最大バイト数を設定する</summary>
		public bool SetMaxWriteByteNum(Int16 _num)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		/// <summary>書き込みコマンドを実行できる最大ブロック数を設定する</summary>
		public bool SetMaxWriteBlockNum(Int16 _num)
		{
			return false;
		}

		//--------------------------------------------------------------------------------------------------//
		// property
		//--------------------------------------------------------------------------------------------------//
		/// <summaryフォーム上の設定の要素名</summary>
		public override string SettingName => "CreateNvmCode";
		
		/// <summary>NVMデータファイルのパス</summary>
		public string NvmFilePass { get; set; }

		/// <summary>結果を保存するファイルへのディレクトリ</summary>
		public string OutputDirectory { get; set; }

		/// <summary>NVMデータ書き込みを行うRSコマンド</summary>
		public string SendCommand { get; set; }

		/// <summary>NVMデータ書き込みを行うRAMモニタコマンド</summary>
		public string RamCommand { get; set; }

		/// <summary>コメント</summary>
		public string Comment { get; set; }

		/// <summary>書き込みを行う先頭アドレス番号(0x0000~0xffffまで)</summary>
		public int BeginWriteAddress { get; set; }

		/// <summary>書き込みを行う末尾アドレス番号(0x0000~0xffffまで)</summary>
		public int EndWriteAddress { get; set; }

		/// <summary>書き込みコマンドで一度に書き込めるアドレスの最小バイト数</summary>
		public ushort MinWriteByteNum { get; set; }

		/// <summary>書き込みコマンドで一度に書き込めるアドレスの最大バイト数</summary>
		public ushort MaxWriteByteNum { get; set; }

		/// <summary>書き込みコマンドを実行できる最大ブロック数</summary>
		public ushort MaxWriteBlockNum { get; set; }

		/// <summary>書き込みコマンドでのアドレス指定時、H/Lを反転させますか?</summary>
		public bool IsReverseAddress { get; set; }
	}
}
