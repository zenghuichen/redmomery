using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace redmomery.Model
{
	public partial class View_T_U
	{
		public int T_ID { get; set; }
		public int M_ID { get; set; }
		public DateTime F_TIME { get; set; }
		public int U_ID { get; set; }
		public int N_RESPONSE { get; set; }
		public string TITLE { get; set; }
		public object Context { get; set; }
		public int N_YES { get; set; }
		public DateTime pass_TIME { get; set; }
		public int Authonrity { get; set; }
		public string T_key { get; set; }
		public string MD5 { get; set; }
		public int is_pass { get; set; }
		public string USER_NETNAME { get; set; }
		public string USER_IMG { get; set; }
	}
}
