using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;


namespace ShootingApp
{
	public static class Effect
	{	
		/// <summary>
		/// スプライトを見えなくし、一定時間後元に戻すエフェクト
		/// </summary>
		/// <param name='sprite'>
		/// Sprite.
		/// </param>
		public static void Disappear(SpriteUV sprite){
			Global.characterActive = false;
			var seq = new Sequence();
			seq.Add(new CallFunc(()=>Disappear1(sprite)));
			seq.Add(new CallFunc(()=>{sprite.Visible = false;}));
			seq.Add(new MoveBy(new Vector2(0,0),2));
			seq.Add(new CallFunc(()=>Appear(sprite)));
			sprite.RunAction(seq);
			
		}
		private static void Disappear1(SpriteUV sprite){
			sprite.RunAction(new RotateBy(Vector2.Rotation(FMath.DegToRad * 180.0f),0.3f));
			//sprite.RunAction(new SkewTo(new Vector2(1,1),1));
			sprite.RunAction(new ScaleTo(new Vector2(0.1f,0.1f),2));
			Sounds.PlayHidan();
		}
		
		private static void Appear(SpriteUV sprite){
			sprite.RunAction(new RotateTo(new Vector2(1,0),0));
			sprite.RunAction(new ScaleTo(new Vector2(0.8f,0.8f),0));
			sprite.Visible = true;
			Global.characterActive = true;
		}
		
		private static TextureInfo waveTextureInfo;
		private static TextureInfo textTextureInfo;
		private static TextureInfo bgTextureInfo;
		private static SpriteUV waveSprite;
		private static SpriteUV textSprite;
		private static SpriteUV bgSprite;
		
		/// <summary>
		/// スキル使用時エフェクト
		/// </summary>
		/// <param name='mySpritePosition'>
		/// 自機スプライトの位置
		/// </param>
		public static void SkillUseEffect(Vector2 mySpritePosition){
			var image1 = new Image("/Application/resourses/Bullet01_64x64.png");
			image1 = image1.Crop(new ImageRect(0,0,64,64));
			var image2 = new Image("/Application/resourses/effect1.png");
			image2 = image2.Resize(new ImageSize(960,180));
			
			var waveTexture = Convert.CreateTextureFromImage(image1);
			image2.Decode();
			var bgTexture = Convert.CreateTextureFromImage(image2);
			
			image1.Dispose();
			image2.Dispose();
			
			var skillName = "";
			switch(Global.setSkill){
			case SkillID.Default :
				skillName = "The WORLD";
				break;
			case SkillID.Skill1 :	
				skillName = "Refrection";
				break;
			case SkillID.Skill2 :	
				skillName = "";
				break;
			case SkillID.Skill3 :	
				skillName = "";
				break;	
			}
			var textTexture = Convert.CreateTextureFromText(skillName,new Font(FontAlias.System,120,FontStyle.Bold | FontStyle.Italic),0xFFFFFF00) ;			
			
			waveTextureInfo = new TextureInfo(waveTexture);
			textTextureInfo = new TextureInfo(textTexture);
			bgTextureInfo = new TextureInfo(bgTexture);
			
			waveSprite = new SpriteUV(){TextureInfo = waveTextureInfo};
			textSprite = new SpriteUV(){TextureInfo = textTextureInfo};
			bgSprite = new SpriteUV(){TextureInfo = bgTextureInfo};
			
			waveSprite.Quad.S = waveTextureInfo.TextureSizef;
			textSprite.Quad.S = textTextureInfo.TextureSizef;
			bgSprite.Quad.S = bgTextureInfo.TextureSizef;
			
			waveSprite.CenterSprite();
			textSprite.CenterSprite();
			bgSprite.CenterSprite();
			
			waveSprite.Position = mySpritePosition;
			textSprite.Position = new Vector2(1500,272);
			bgSprite.Position = new Vector2(1500,272);
			
			Scenes.sceneOnGame.AddChild(waveSprite);
			Scenes.sceneOnGame.AddChild(bgSprite);
			Scenes.sceneOnGame.AddChild(textSprite);
			
			var seq0 = new Sequence();
			seq0.Add(new MoveTo(new Vector2(480,272),1));
			seq0.Add(new DelayTime(1.0f));
			seq0.Add(new MoveTo(new Vector2(-500,272),1));
			
			var seq1 = new Sequence();
			seq1.Add(new MoveTo(new Vector2(480,272),1));
			seq1.Add(new DelayTime(1.0f));
			seq1.Add(new MoveTo(new Vector2(-500,272),1));
			
			var seq2 = new Sequence();
			seq2.Add(new DelayTime(3.5f));
			seq2.Add(new CallFunc(()=>{Sounds.PlaySkill2();}));
			seq2.Add(new ScaleTo(new Vector2(40,40),3));
			
			Sounds.PlaySkill1();
			bgSprite.RunAction(seq0);
			textSprite.RunAction(seq1);
			waveSprite.RunAction(seq2);
			
			
		}
		
		public static void Dispose(){
			Scenes.sceneOnGame.RemoveChild(waveSprite,true);
			Scenes.sceneOnGame.RemoveChild(bgSprite,true);
			Scenes.sceneOnGame.RemoveChild(textSprite,true);
		}
	}
}

