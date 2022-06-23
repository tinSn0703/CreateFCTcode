using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFCTcode
{
	class ActionCreateNvmCode
	{
		//--------------------------------------------------------------------------------------------------//
		// type
		//--------------------------------------------------------------------------------------------------//
		private struct NvmData
		{
			public ushort _address;
			public string _data;

			public NvmData(ushort _address, string _data) { this._address = _address; this._data = _data; }
		};

		//--------------------------------------------------------------------------------------------------//
		// field
		//--------------------------------------------------------------------------------------------------//

		private LinkedList<ushort> _list_block_begin_address;
		private LinkedList<NvmData> _list_nvm_data;
		private LinkedList<string> _list_write_code;

		//--------------------------------------------------------------------------------------------------//
		// method
		//--------------------------------------------------------------------------------------------------//
		/// <summary></summary>
		/// <param name="_Setting"></param>
		public void Action(in SettingCreateNvmCode _Setting)
		{

		}

		private void Read(in SettingCreateNvmCode _Setting)
		{

		}
	}
}
