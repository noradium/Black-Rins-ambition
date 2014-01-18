using System;
using System.Collections;
using System.Collections.Generic;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Environment;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Input;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace ShootingApp
{
	public static class Game
	{
		private static Texture2D backGroundTexture;
		private static Texture2D myShipTexture;
		private static TextureInfo backGroundTextureInfo;
		private static TextureInfo myShipTextureInfo;
		
		private static SpriteUV backGroundSprite;
		public static SpriteUV myShipSprite;

		private static GraphicsContext _graphics;
		private static ScreenSize screenSize;
		public static float time;
		public static float timeInSkill;
		public static int tickCount;
		public static StageID playingStageId;
		public static ArrayList myBulletDeleteQueue;  // 弾丸の削除待ちキュー　更新処理の最後で一斉削除する
		public static ArrayList enemyBulletDeleteQueue;
		public static ArrayList enemyDeleteQueue;
		public static ArrayList itemDeleteQueue;
		public static SkillEffectStatus skillEffectStatus = new SkillEffectStatus(false,0);
		public static float SkillTimeCount;
		public static bool defaultSkillInTime;
		public static Random random;
		
		/// <summary>
		/// ゲーム画面初期化　１回呼び出すだけでよい
		/// </summary>
		/// <param name='graphicsContext'>
		/// If set to <c>true</c> graphics context.
		/// </param>
		public static bool InitGame(GraphicsContext graphicsContext){
			
			_graphics = graphicsContext;
			screenSize = new ScreenSize(960,544);
			
			// カメラ初期化
			Scenes.sceneOnGame.Camera.SetViewFromViewport();
			
			Director.Instance.RunWithScene(Scenes.sceneOnGame, true);
			
			return true;
	
		}
		
		/// <summary>
		/// ゲームを開始するメソッド
		/// </summary>
		/// <param name='stageId'>
		/// 開始するステージID
		/// </param>
		public static void StartGame(StageID stageId){
			Scenes.sceneOnGame.Cleanup();
			
			// 背景テクスチャをロード
			backGroundTexture = new Texture2D("Application/resourses/background1.jpg", false);
			backGroundTextureInfo = new Sce.PlayStation.HighLevel.GameEngine2D.Base.TextureInfo(backGroundTexture);
			// 自機テクスチャをロード
			myShipTexture = new Texture2D("Application/resourses/myCharacter.gif", false);
			myShipTextureInfo = new Sce.PlayStation.HighLevel.GameEngine2D.Base.TextureInfo(myShipTexture);
			
			// スプライト作成
			backGroundSprite = new SpriteUV(){TextureInfo = backGroundTextureInfo};
			backGroundSprite.Quad.S = backGroundTextureInfo.TextureSizef;
			
			myShipSprite = new SpriteUV(){TextureInfo = myShipTextureInfo};
			myShipSprite.Quad.S = myShipTextureInfo.TextureSizef;
			myShipSprite.Scale = new Vector2(0.8f,0.8f);
			
			// スプライトの中心をテクスチャの中心に設定
			
			backGroundSprite.CenterSprite();
			myShipSprite.CenterSprite();
			
			// スプライトの表示位置をカメラの中央に配置
			backGroundSprite.Position = Scenes.sceneOnGame.Camera.CalcBounds().Center;
		
			myShipSprite.Position = new Vector2(100,272);
			
			// シーンの子要素としてスプライトを追加
			
			Scenes.sceneOnGame.AddChild(backGroundSprite);
			Scenes.sceneOnGame.AddChild(myShipSprite);
			
			Enemy.InitEnemy();
			MyBullet.InitMyBullet();
			EnemyBullet.InitEnemyBullet();
			Item.InitItem();
			Rayer.InitRayer();
			
			// 乱数発生インスタンスを生成
			random = new Random();
			
			// 削除待ちキュー作成
			myBulletDeleteQueue = new ArrayList();
			enemyBulletDeleteQueue = new ArrayList();
			enemyDeleteQueue = new ArrayList();
			itemDeleteQueue = new ArrayList();

			Global.characterStack = 4;
			Global.characterActive = true;
			Global.score = 0;
			Global.skillPoint = 0;
			Global.isClear = false;
			Global.isGameOver = false;
			Rayer.UpdateScore(0);
			Rayer.UpdateCharacterStack(0);
			Rayer.UpdateSkillPoint(0);
			time = 0;
			tickCount = 0;
			playingStageId = stageId;
			SkillTimeCount = 0.0f;
			defaultSkillInTime = false;
			
			Stage.StartStage1();
			
			Director.Instance.Update ();
			Scenes.sceneOnGame.RegisterDisposeOnExitRecursive();
			Scheduler.Instance.Schedule(Scenes.sceneOnGame,Tick,0.01f,false);
		}
		
		
		
		/// <summary>
		/// ゲーム中の処理をするメソッド
		/// </summary>
		/// <param name='dt'>
		/// Dt.
		/// </param>
		public static void Tick(float dt){
			time += dt;
			tickCount++;
			
			
			
			
			//デバッグ用
			if(Peripheral.Down(GamePadButtons.Select)){
				Global.isClear = true;
				Global.score = 500000;
			}
			
			
			
			
			// スキルエフェクト描画中の処理
			if(skillEffectStatus.Status == true){
				time -= dt;
				timeInSkill += dt;
				
				if(skillEffectStatus.EndTime < timeInSkill){
					if(Global.setSkill == SkillID.Default){
						skillEffectStatus.Status = false;
						defaultSkillInTime = true;
						SkillTimeCount = 5.0f;
						Sounds.PauseBgm();
						Sounds.PlayTicktuck();
					}
					if(Global.setSkill == SkillID.Skill1){
						skillEffectStatus.Status = false;
						Enemy.ResumeAction();
					}
				}
				return;
			}
			
			// Default Skill 用タイマー
			if(defaultSkillInTime){
				SkillTimeCount -= dt;
				time -= dt;
				if(SkillTimeCount < 0){
					Enemy.ResumeAction();
					defaultSkillInTime = false;	
					Sounds.StopTicktuck();
					Sounds.ResumeBgm();
				}
			}
			
			
			// 入力デバイス情報更新
			Peripheral.Update(dt);
			
			// スキル使用判定
			if(Peripheral.TouchDown() && Global.skillPoint >= 3){
				skillEffectStatus.Status = true;
				
			
				if(Global.setSkill == SkillID.Default){
					skillEffectStatus.EndTime = time + 6.5f;
				
					Enemy.PauseAction();
					Effect.SkillUseEffect(myShipSprite.Position);
				}
				if(Global.setSkill == SkillID.Skill1){
					skillEffectStatus.EndTime = time + 6.5f;
					
					Enemy.PauseAction();
					Effect.SkillUseEffect(myShipSprite.Position);
					EnemyBullet.moveToMyBulletList(myShipSprite.Position);
				}		
				timeInSkill = time;
				Rayer.UpdateSkillPoint(-3);
			}
			
			
			// 自機の移動処理
			if(Global.characterActive == true && CharacterCollisionDetection(EnemyBullet.BulletList) == true){
				Effect.Disappear(myShipSprite);
				if(Global.characterStack == 0){
					Global.isGameOver = true;
				}else{
					Rayer.UpdateCharacterStack(-1);
					foreach(Bullet1 bl in EnemyBullet.BulletList){
						enemyBulletDeleteQueue.Add(bl);
					}
				}		
			}
			var newPosition = myShipSprite.Position;
			if(Peripheral.Down(GamePadButtons.Down)){
				if(myShipSprite.Position.Y > myShipSprite.TextureInfo.TextureSizef.Y/2)
					newPosition += new Vector2(0,-2);
			}else if(Peripheral.Down(GamePadButtons.Up)){
				if(myShipSprite.Position.Y < screenSize.Height - myShipSprite.TextureInfo.TextureSizef.Y/2)
					newPosition += new Vector2(0,2);
			}
			if(Peripheral.Down(GamePadButtons.Left)){
				if(myShipSprite.Position.X > myShipSprite.TextureInfo.TextureSizef.X/2)
					newPosition += new Vector2(-2,0);
			}else if(Peripheral.Down(GamePadButtons.Right)){
				if(myShipSprite.Position.X < screenSize.Width - myShipSprite.TextureInfo.TextureSizef.X/2)
					newPosition += new Vector2(2,0);
			}
			myShipSprite.RunAction(new MoveTo(newPosition,0.0f));
		
			
			// 背景の移動処理
			if(!defaultSkillInTime){
				var newbgPosition = backGroundSprite.Position;
				if(backGroundSprite.Position.X > 0)
					newbgPosition += new Vector2(-1,0);
				else
					newbgPosition = new Vector2(960,272);
				backGroundSprite.RunAction(new MoveTo(newbgPosition,0.0f));
			}
			
			// 敵の更新処理
			
			Bullet1 bul;
			foreach(Enemy1 en in Enemy.EnemyList){
				if(en.TimeOut < time){
					enemyDeleteQueue.Add(en);
				}else if((bul = Enemy.EnemyCollisionDetection(en,MyBullet.BulletList)) != null){
					myBulletDeleteQueue.Add(bul);
					if(--en.CurrentHP == 0){
						Rayer.UpdateScore(en.MaxHP * 1000);
						Sounds.PlayTekihidan();
						enemyDeleteQueue.Add(en);
						
						// 20/100の確率でアイテム生成
						if(random.Next(100) < 20){
							Item.NewItem(ItemType.SP,en.Sprite.Position);	
						}
						
						if(en.BulletType == BulletType.Boss){
							Global.isClear = true;
						}
					}
				}
				if(en.BulletType == BulletType.Boss){
					Rayer.UpdateBossHp(en.CurrentHP,en.MaxHP);
				}
			}
			
			// アイテム取得処理
			{
				Item1 item;
				if((item = Item.ItemCollisionDetection(myShipSprite.Position)) != null && Global.characterActive){
					Rayer.UpdateSkillPoint(1);
					Rayer.UpdateScore(1000);
					itemDeleteQueue.Add(item);
				}
			}
			// 弾丸の更新処理
			
			// xボタンが押されていたら新しく弾丸を生成
			if(Peripheral.Down(GamePadButtons.Cross) && tickCount%30 == 0 && Global.characterActive == true){
				MyBullet.MakeNewBullet(myShipSprite.Position.X + 50, myShipSprite.Position.Y,5,0);
				 Sounds.PlayShot();
				Rayer.UpdateScore(10);
			}
			// 敵の弾丸生成
			if(!defaultSkillInTime){
				Enemy.GenerateEnemyBullets(tickCount,myShipSprite.Position);
			}
			
			// スプライトの移動　　画面外のスプライトを削除待ちキューに追加
			foreach(Bullet1 bl in MyBullet.BulletList){
				if(bl.Sprite.Position.X < 0 || bl.Sprite.Position.Y < 0 || bl.Sprite.Position.X > screenSize.Width || bl.Sprite.Position.Y > screenSize.Height){
					myBulletDeleteQueue.Add(bl);
				}
				MyBullet.Update(bl);
			}
			if(!defaultSkillInTime){
				foreach(Bullet1 bl in EnemyBullet.BulletList){
					if(bl.Sprite.Position.X < 0 || bl.Sprite.Position.Y < 0 || bl.Sprite.Position.X > screenSize.Width || bl.Sprite.Position.Y > screenSize.Height){
						enemyBulletDeleteQueue.Add(bl);
					}
					EnemyBullet.Update(bl);
				}
			}
			foreach(Item1 item in Item.ItemList){
				if(item.Sprite.Position.X < 0){
					itemDeleteQueue.Add(item);
				}
				Item.Update(item);
			}
			
			// ステージ更新
			if(time > ((StageEventData)Stage.stageTimeTable[0]).Time){
				((StageEventData)Stage.stageTimeTable[0]).Func();
				Stage.stageTimeTable.RemoveAt(0);
			}
			
			
			
			
			// 自機弾丸の一斉削除
			foreach(Bullet1 bl in myBulletDeleteQueue){
				MyBullet.RemoveBullet(bl);
			}
			myBulletDeleteQueue.Clear();
			// 敵弾丸の一斉削除
			foreach(Bullet1 bl in enemyBulletDeleteQueue){
				EnemyBullet.RemoveBullet(bl);
			}
			enemyBulletDeleteQueue.Clear();
			// 敵の一斉削除
			if(!defaultSkillInTime){
				foreach(Enemy1 en in enemyDeleteQueue){
					Enemy.RemoveEnemy(en);
				}
				enemyDeleteQueue.Clear();
			}
			// アイテムの一斉削除
			foreach(Item1 item in itemDeleteQueue){
				Item.removeItem(item);
			}
			itemDeleteQueue.Clear();
			
			
			// GameOver ステージクリア時の処理
			if(Global.isGameOver){
				Global.isStartGame = false;
				Scheduler.Instance.UnscheduleAll();
				Sounds.StopBgm();
				
				Sce.PlayStation.HighLevel.UI.UISystem.SetScene(Scenes.gameOverScene);
				var resultDialog = new Result(1,playingStageId);
				Sounds.PlayGameover();
				TextureDispose();
				Scenes.sceneOnGame.OnExit();
				resultDialog.Show();
				
			}else if(Global.isClear){
				Global.isStartGame = false;
				Scheduler.Instance.UnscheduleAll();
				Sounds.StopBgm();
					
				Sce.PlayStation.HighLevel.UI.UISystem.SetScene(Scenes.stageClearScene);
				var resultDialog = new Result(Global.score/2000, playingStageId);
				Sounds.PlayStageClear();
				TextureDispose();
				Scenes.sceneOnGame.OnExit();
				resultDialog.Show();
			}
			
		}
		
		/// <summary>
		/// 自機と敵弾丸の当たり判定
		/// </summary>
		/// <returns>
		/// bool
		/// </returns>
		/// <param name='bulletlist'>
		/// If set to <c>true</c> bulletlist.
		/// </param>
		public static bool CharacterCollisionDetection(ArrayList bulletlist){
			foreach(Bullet1 bl in bulletlist){
				if(myShipSprite.Position.Distance(bl.Sprite.Position) < 20){
					return true;
				}
			}
			return false;
		}
		
		public static void Update(){
			Director.Instance.Update();
		}
		
		public static void Render(){
			_graphics.Enable(EnableMode.Blend, true);
			_graphics.Enable(EnableMode.DepthTest, false);
			
			// 描画メソッド呼び出し
			Director.Instance.Render();
			// スクリーン更新
			Director.Instance.GL.Context.SwapBuffers();
			// swap
			Director.Instance.PostSwap();
		}
		private static void TextureDispose(){
			backGroundTexture.Dispose();
			backGroundTextureInfo.Dispose();
			myShipTexture.Dispose();
			myShipTextureInfo.Dispose();
			
			MyBullet.TextureDispose();
			EnemyBullet.TextureDispose();
			
			
		}
	}
}

