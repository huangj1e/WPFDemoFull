using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemoFull.Core.EventArgs;

public class LangChangeEvent : PubSubEvent<string> { }