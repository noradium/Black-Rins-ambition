using System;
using System.Collections;

using Sce.PlayStation.Core;
using Sce.PlayStation.HighLevel.GameEngine2D;


namespace ShootingApp
{
	public enum StageID{Stage1=1,Stage2,Stage3}
	
	public static class Stage
	{
		
		public static ArrayList stageTimeTable;
		
		/// <summary>
		/// ステージ１のデータを生成
		/// </summary>
		public static void StartStage1(){
			stageTimeTable = new ArrayList();
			
			stageTimeTable.Add(new StageEventData(3,()=>SetEnemy(EnemyType.Enemy2,960,272,BulletType.Single,50,1,new Vector2(0,0),3,5)));
			stageTimeTable.Add(new StageEventData(3,()=>SetEnemy(EnemyType.Enemy2,960,272,BulletType.Single,50,1,new Vector2(0,544),3,5)));
			
			stageTimeTable.Add(new StageEventData(5,()=>SetEnemy(EnemyType.Enemy2,960,400,BulletType.Circle,50,1,new Vector2(0,100),5,7)));
			stageTimeTable.Add(new StageEventData(5.2f,()=>SetEnemy(EnemyType.Enemy2,960,400,BulletType.Single,50,1,new Vector2(0,100),5.2f,7)));
			stageTimeTable.Add(new StageEventData(5.4f,()=>SetEnemy(EnemyType.Enemy2,960,400,BulletType.Single,50,1,new Vector2(0,100),5.4f,7)));
			stageTimeTable.Add(new StageEventData(5.6f,()=>SetEnemy(EnemyType.Enemy2,960,400,BulletType.Circle,50,1,new Vector2(0,100),5.6f,7)));
			stageTimeTable.Add(new StageEventData(5.8f,()=>SetEnemy(EnemyType.Enemy2,960,400,BulletType.Single,50,1,new Vector2(0,100),5.8f,7)));
			
			stageTimeTable.Add(new StageEventData(7,()=>SetEnemy(EnemyType.Enemy5,960,272,BulletType.CircleAimed,150,1,new Vector2(0,272),7,10)));
			stageTimeTable.Add(new StageEventData(9,()=>SetEnemy(EnemyType.Enemy5,960,450,BulletType.CircleAimed,150,1,new Vector2(0,450),8,10)));
			stageTimeTable.Add(new StageEventData(11,()=>SetEnemy(EnemyType.Enemy5,960,180,BulletType.CircleAimed,150,1,new Vector2(0,180),9,10)));
			stageTimeTable.Add(new StageEventData(13,()=>SetEnemy(EnemyType.Enemy5,960,200,BulletType.CircleAimed,150,1,new Vector2(0,200),10,10)));
			
			stageTimeTable.Add(new StageEventData(17,()=>SetEnemy(EnemyType.Enemy2,960,272,BulletType.LineAimed,100,1,new Vector2(0,272),17,10)));
			stageTimeTable.Add(new StageEventData(18,()=>SetEnemy(EnemyType.Enemy2,960,222,BulletType.LineAimed,100,1,new Vector2(0,222),18,10)));
			stageTimeTable.Add(new StageEventData(18,()=>SetEnemy(EnemyType.Enemy2,960,322,BulletType.LineAimed,100,1,new Vector2(0,322),18,10)));
			stageTimeTable.Add(new StageEventData(19,()=>SetEnemy(EnemyType.Enemy2,960,172,BulletType.LineAimed,100,1,new Vector2(0,172),19,10)));
			stageTimeTable.Add(new StageEventData(19,()=>SetEnemy(EnemyType.Enemy2,960,372,BulletType.LineAimed,100,1,new Vector2(0,372),19,10)));
			stageTimeTable.Add(new StageEventData(20,()=>SetEnemy(EnemyType.Enemy2,960,122,BulletType.LineAimed,100,1,new Vector2(0,122),20,10)));
			stageTimeTable.Add(new StageEventData(20,()=>SetEnemy(EnemyType.Enemy2,960,422,BulletType.LineAimed,100,1,new Vector2(0,422),20,10)));
			
			
			stageTimeTable.Add(new StageEventData(23,()=>SetEnemy(EnemyType.Enemy4,960,100,BulletType.SingleUp,70,1,new Vector2(0,100),23,10)));
			stageTimeTable.Add(new StageEventData(24,()=>SetEnemy(EnemyType.Enemy4,960,100,BulletType.SingleUp,70,1,new Vector2(0,100),24,10)));
			stageTimeTable.Add(new StageEventData(25,()=>SetEnemy(EnemyType.Enemy4,960,100,BulletType.SingleUp,70,1,new Vector2(0,100),25,10)));
			stageTimeTable.Add(new StageEventData(26,()=>SetEnemy(EnemyType.Enemy4,960,100,BulletType.SingleUp,70,1,new Vector2(0,100),26,10)));
			stageTimeTable.Add(new StageEventData(27,()=>SetEnemy(EnemyType.Enemy4,960,100,BulletType.SingleUp,70,1,new Vector2(0,100),27,10)));
			
			
			stageTimeTable.Add(new StageEventData(30,()=>SetFallingEnemy(EnemyType.Enemy3,800,544,BulletType.SingleAimed,100,3,30,16)));
			stageTimeTable.Add(new StageEventData(33,()=>SetFallingEnemy(EnemyType.Enemy3,700,544,BulletType.SingleAimed,100,3,33,16)));
			stageTimeTable.Add(new StageEventData(37,()=>SetFallingEnemy(EnemyType.Enemy3,850,544,BulletType.SingleAimed,100,3,37,16)));
			
			
			stageTimeTable.Add(new StageEventData(40,()=>SetEnemy(EnemyType.Enemy2,960,540,BulletType.SingleAimed,150,1,new Vector2(0,540),40,10)));
			stageTimeTable.Add(new StageEventData(41,()=>SetEnemy(EnemyType.Enemy2,960,500,BulletType.SingleAimed,150,1,new Vector2(0,500),41,10)));
			stageTimeTable.Add(new StageEventData(42,()=>SetEnemy(EnemyType.Enemy2,960,460,BulletType.SingleAimed,150,1,new Vector2(0,460),42,10)));
			stageTimeTable.Add(new StageEventData(43,()=>SetEnemy(EnemyType.Enemy2,960,420,BulletType.SingleAimed,150,1,new Vector2(0,420),43,10)));
			stageTimeTable.Add(new StageEventData(44,()=>SetEnemy(EnemyType.Enemy2,960,380,BulletType.SingleAimed,150,1,new Vector2(0,380),44,10)));
			stageTimeTable.Add(new StageEventData(45,()=>SetEnemy(EnemyType.Enemy2,960,340,BulletType.SingleAimed,150,1,new Vector2(0,340),45,10)));
			stageTimeTable.Add(new StageEventData(46,()=>SetEnemy(EnemyType.Enemy2,960,300,BulletType.SingleAimed,150,1,new Vector2(0,300),46,10)));
			stageTimeTable.Add(new StageEventData(47,()=>SetEnemy(EnemyType.Enemy2,960,260,BulletType.SingleAimed,150,1,new Vector2(0,260),47,10)));
			stageTimeTable.Add(new StageEventData(48,()=>SetEnemy(EnemyType.Enemy2,960,220,BulletType.SingleAimed,150,1,new Vector2(0,220),48,10)));
			stageTimeTable.Add(new StageEventData(49,()=>SetEnemy(EnemyType.Enemy2,960,180,BulletType.SingleAimed,150,1,new Vector2(0,180),49,10)));
			stageTimeTable.Add(new StageEventData(50,()=>SetEnemy(EnemyType.Enemy2,960,140,BulletType.SingleAimed,150,1,new Vector2(0,140),50,10)));
			stageTimeTable.Add(new StageEventData(51,()=>SetEnemy(EnemyType.Enemy2,960,100,BulletType.SingleAimed,150,1,new Vector2(0,100),51,10)));
			stageTimeTable.Add(new StageEventData(52,()=>SetEnemy(EnemyType.Enemy2,960,60,BulletType.SingleAimed,150,1,new Vector2(0,60),52,10)));
			stageTimeTable.Add(new StageEventData(53,()=>SetEnemy(EnemyType.Enemy2,960,20,BulletType.SingleAimed,150,1,new Vector2(0,20),53,10)));
			stageTimeTable.Add(new StageEventData(54,()=>SetEnemy(EnemyType.Enemy2,960,272,BulletType.SingleAimed,150,1,new Vector2(0,272),54,10)));
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			stageTimeTable.Add(new StageEventData(58,()=>Sounds.StopBgm()));
			stageTimeTable.Add(new StageEventData(59,()=>Sounds.PlaySiren()));
			stageTimeTable.Add(new StageEventData(61,()=>Sounds.PlayStage1boss()));
			
			stageTimeTable.Add(new StageEventData(63,()=>SetBossEnemy(EnemyType.Boss1,10,10)));
		
		
			stageTimeTable.Add(new StageEventData(999999,()=>{})); //ダミー
			Sounds.PlayStage1();
	    }
		
		/// <summary>
		/// 普通の敵を生成
		/// </summary>
		/// <param name='enemyId'>
		/// Enemy identifier.
		/// </param>
		/// <param name='fromX'>
		/// From x.
		/// </param>
		/// <param name='fromY'>
		/// From y.
		/// </param>
		/// <param name='bulletType'>
		/// Bullet type.
		/// </param>
		/// <param name='attackInterval'>
		/// Attack interval.
		/// </param>
		/// <param name='hp'>
		/// Hp.
		/// </param>
		/// <param name='to'>
		/// To.
		/// </param>
		/// <param name='startTime'>
		/// Start time.
		/// </param>
		/// <param name='time'>
		/// Time.
		/// </param>
		public static void SetEnemy(EnemyType enemyId, float fromX, float fromY,BulletType bulletType, int attackInterval, int hp, Vector2 to,float startTime,float time){
			Enemy.MakeNewEnemy(enemyId,fromX,fromY,bulletType,attackInterval,hp,startTime+time).Sprite.RunAction(new MoveTo(to - new Vector2(400,0),time));
			
		}
		
		/// <summary>
		/// 上から下に落ちていく敵を生成
		/// </summary>
		/// <param name='enemyId'>
		/// Enemy identifier.
		/// </param>
		/// <param name='fromX'>
		/// From x.
		/// </param>
		/// <param name='fromY'>
		/// From y.
		/// </param>
		/// <param name='bulletType'>
		/// Bullet type.
		/// </param>
		/// <param name='attackInterval'>
		/// Attack interval.
		/// </param>
		/// <param name='hp'>
		/// Hp.
		/// </param>
		/// <param name='startTime'>
		/// Start time.
		/// </param>
		/// <param name='time'>
		/// Time.
		/// </param>
		public static void SetFallingEnemy(EnemyType enemyId, float fromX, float fromY,BulletType bulletType, int attackInterval, int hp, float startTime,float time){
			var seq = new Sequence();
			seq.Add(new MoveBy(new Vector2(-50,-50),1){
				Tween = (t) => t*t,	
			});
			seq.Add(new RotateTo(Vector2.Rotation(FMath.DegToRad*350.0f),0.4f));
			seq.Add(new MoveBy(new Vector2(50,-50),1){
				Tween = (t) => t*t,
			});
			seq.Add(new RotateTo(Vector2.Rotation(FMath.DegToRad*10.0f),0.4f));
			
			var repeat = new Repeat(seq,10);
			
			Enemy.MakeNewEnemy(enemyId,fromX,fromY,bulletType,attackInterval,hp,startTime+time).Sprite.RunAction(repeat);
			
			
		}
		
		/// <summary>
		/// ボスを生成
		/// </summary>
		/// <param name='enemyId'>
		/// Enemy identifier.
		/// </param>
		/// <param name='hp'>
		/// Hp.
		/// </param>
		/// <param name='startTime'>
		/// Start time.
		/// </param>
		public static void SetBossEnemy(EnemyType enemyId, int hp, float startTime){
			var seq = new Sequence();
			var point_center = new Vector2(700,272);
			var point_under = new Vector2(700,140);
			var point_top = new Vector2(700,404);
			var point_forward = new Vector2(400,272);
			
			seq.Add(new MoveTo(point_center,2));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeCircleBullets(point_center.X,point_center.Y,10,2)));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeCircleBullets(point_center.X,point_center.Y,7,5)));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeCircleBullets(point_center.X,point_center.Y,13,10)));
			seq.Add(new MoveTo(point_forward,3));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSpiralBullets(point_forward.X,point_forward.Y,17,5)));
			seq.Add(new MoveTo(point_under,3));

			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,0)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,1)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,2)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,3)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,4)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,5)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,6)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,7)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,6)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,5)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,4)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,3)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,2)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,1)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,0)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,1)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,2)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,3)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,4)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,5)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,6)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,7)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,6)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,5)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,4)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,3)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,2)));
			seq.Add(new MoveTo(point_under,0.2f));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeSingleBullet(point_under.X,point_under.Y,-3,1)));
			
			seq.Add(new MoveTo(point_top,3));
			seq.Add(new CallFunc(()=>AimedBlockBullet(point_top)));
			
			seq.Add(new MoveTo(point_center,3));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeLineBullets(point_center.X,point_center.Y,10,50,-5,0)));
			seq.Add(new MoveTo(point_center,1));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeLineBullets(point_center.X,point_center.Y,10,40,-5,0)));
			seq.Add(new MoveTo(point_center,1));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeLineBullets(point_center.X,point_center.Y,10,50,-5,0)));
			seq.Add(new MoveTo(point_center,1));
			seq.Add(new CallFunc(()=>EnemyBullet.MakeLineBullets(point_center.X,point_center.Y,10,40,-5,0)));
			
			
			var repeat = new RepeatForever(){
				InnerAction = seq
			};
			
			Enemy.MakeNewEnemy(enemyId,960,272,BulletType.Boss,999999,hp,999999).Sprite.RunAction(repeat);
			
		}
		
		public static void AimedBlockBullet(Vector2 point){
			var directionVector = Vector2.Normalize(Game.myShipSprite.Position - point);
			EnemyBullet.MakeDirectionCircleBullets(point.X,point.Y,6,10,directionVector.X*3,directionVector.Y*3);
			EnemyBullet.MakeDirectionCircleBullets(point.X,point.Y,6,20,directionVector.X*3,directionVector.Y*3);
			EnemyBullet.MakeDirectionCircleBullets(point.X,point.Y,6,30,directionVector.X*3,directionVector.Y*3);
			EnemyBullet.MakeDirectionCircleBullets(point.X,point.Y,6,40,directionVector.X*3,directionVector.Y*3);
			EnemyBullet.MakeDirectionCircleBullets(point.X,point.Y,6,50,directionVector.X*3,directionVector.Y*3);
			EnemyBullet.MakeDirectionCircleBullets(point.X,point.Y,6,60,directionVector.X*3,directionVector.Y*3);
			EnemyBullet.MakeDirectionCircleBullets(point.X,point.Y,6,70,directionVector.X*3,directionVector.Y*3);
			
		}
		
	}
}

