///////////////////////////////////////////////////////////
//  SQLHelper.cs
//  Implementation of the Class SQLHelper
//  Generated by Enterprise Architect
//  Created on:      12-Kas-2022 10:58:52
//  Original author: aykut
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DAL {
	public class SQLHelper : DBHelper {

		public SQLHelper(){
			Console.ForegroundColor = ConsoleColor.DarkCyan;
		}

		~SQLHelper(){
			Console.ResetColor();
		}

		public override void Connect(){
            Console.WriteLine("SQL Server ba�lant�s� olu�tu");
		}

		public override void Disconnect(){
			Console.WriteLine("SQL Server ba�lant�s� kapat�ld�");
		}

		/// 
		/// <param name="commandText">sql komut i�eri�i</param>
		public override void Run(string commandText){
			Console.WriteLine($"{commandText}\tT-SQL completed...");
		}

	}//end SQLHelper

}//end namespace Package1