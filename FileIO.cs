using System;

namespace ShootingApp
{
	
	public static class FileIO
	{
		/// <summary>
		/// 保存ファイル名
		/// </summary>
		private const string SAVEFILE = @"/Documents/savedata.dat";
		
		
		/// <summary>
		/// ファイルにデータをセーブ
		/// </summary>
		public static void SaveData(){
			using(var fs = System.IO.File.Open(@SAVEFILE,System.IO.FileMode.CreateNew)){
				// バイナリライター作成
				var bw = new System.IO.BinaryWriter(fs);
				
				// Write data
				bw.Write(Global.isStageOpened[(int)StageID.Stage1]);
				bw.Write(Global.isStageOpened[(int)StageID.Stage2]);
				bw.Write(Global.isStageOpened[(int)StageID.Stage3]);
				
				bw.Write(Global.characterLevel);
				bw.Write(Global.characterExp);
				
				bw.Close();
			}
		}
		
		/// <summary>
		/// ファイルからデータをロード
		/// </summary>
		public static void LoadData(){
			if(System.IO.File.Exists(@SAVEFILE)){
				using(var fs = System.IO.File.Open(@SAVEFILE,System.IO.FileMode.Open)){
					// バイナリリーダ作成
					var br = new System.IO.BinaryReader(fs);
					
					// Read data
					Global.isStageOpened[(int)StageID.Stage1] = br.ReadBoolean();
					Global.isStageOpened[(int)StageID.Stage2] = br.ReadBoolean();
					Global.isStageOpened[(int)StageID.Stage3] = br.ReadBoolean();
					
					Global.characterLevel = br.ReadInt32();
					Global.characterExp = br.ReadInt32();
					
					br.Close();
				}
			}else{
				Global.isStageOpened[(int)StageID.Stage1] = true;
				Global.isStageOpened[(int)StageID.Stage2] = false;
				Global.isStageOpened[(int)StageID.Stage3] = false;
				
				Global.characterLevel = 1;
				Global.characterExp = 0;
			}
		}
		
		public static void Initialize(){
			if(System.IO.File.Exists(SAVEFILE)){
				System.IO.File.Delete(SAVEFILE);
				System.Console.WriteLine("初期化しました");
				LoadData();
				Sounds.PlayOk();
			}
			
		}
		
	}
}

