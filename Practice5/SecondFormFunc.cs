using System;
using System.Collections.Generic;
using System.Text;

namespace Practice5
{
	public class SecondFormFunc
	{
		string m_szTriggerEvent1 = "You Press Event1.";
		string m_szTriggerEvent2 = "You Press Event2.";

		// Delegate for Click Trigger 
		public delegate void TriggerEventClickHandler( string szString );
		// Event for Click Trigger
		public event TriggerEventClickHandler TriggerEvent;

		// How To Trigger Event
		public void Trigger( string szTriggerString )
		{
			//Console.WriteLine(szTriggerString);
			if( TriggerEvent != null ) {
				TriggerEvent( szTriggerString );
			}
		}

		// Trigger Event 1
		public void TriggerEvent1()
		{
			Trigger( m_szTriggerEvent1 );
		}

		// Trigger Event 2
		public void TriggerEvent2()
		{
			Trigger( m_szTriggerEvent2 );
		}
	}
}
