using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateFCTcode
{
	public abstract class ApplicationAction
	{
		public abstract void Action(in string _PathInput, in string _PathOutput, in string _Pathreference = "");

		public virtual string InputConfigText { get; }
		public virtual string OutputConfigText { get; }
		public virtual string ReferenceConfigText { get; }
		public virtual string ModeConfigText { get; }
	}
}
