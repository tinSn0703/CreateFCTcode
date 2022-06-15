using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFCTcode
{
	public class ApplicatonMode
	{
		private const string c_MODE_NAME_DRAW_FCTP				= "Draw FCTP";
		private const string c_MODE_NAME_DRAW_FCTP_FROM_XFDF	= "Draw FCTP from XFDF";
		private const string c_MODE_NAME_DROP_FCTJ				= "Drop FCTJ";
		private const string c_MODE_NAME_CREATE_LIST			= "Create List";
		private const string c_MODE_NAME_EXTRACT_FROM_XFDF		= "Extract from xfdf";

		private object[] _ModeList = new object[] {
				c_MODE_NAME_DRAW_FCTP,
				c_MODE_NAME_DRAW_FCTP_FROM_XFDF,
				c_MODE_NAME_DROP_FCTJ,
				c_MODE_NAME_CREATE_LIST,
				c_MODE_NAME_EXTRACT_FROM_XFDF};

		public object[] ModeList => _ModeList;

		public string DEFAULT_MODE_NAME => c_MODE_NAME_DRAW_FCTP;

		public string MODE_NAME_DRAW_FCTP			=> c_MODE_NAME_DRAW_FCTP;
		public string MODE_NAME_DRAW_FCTP_FROM_XFDF	=> c_MODE_NAME_DRAW_FCTP_FROM_XFDF;
		public string MODE_NAME_DROP_FCTJ			=> c_MODE_NAME_DROP_FCTJ;
		public string MODE_NAME_CREATE_LIST			=> c_MODE_NAME_CREATE_LIST;
		public string MODE_NAME_EXTRACT_FROM_XFDF	=> c_MODE_NAME_EXTRACT_FROM_XFDF;
	}
}
