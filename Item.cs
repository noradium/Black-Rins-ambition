using System;
using System.Collections;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;


namespace ShootingApp
{
	public enum ItemType{SP}
	
	/// <summary>
	/// １つのアイテムを管理するクラス
	/// </summary>
	public class Item1
	{
		public ItemType Type;
		public SpriteUV Sprite;
		
		public Item1(ItemType type){
			Type = type;
		}
	}
	
	/// <summary>
	/// アイテムをまとめて管理するクラス
	/// </summary>
	public static class Item
	{
		public static ArrayList ItemList; // アイテムを登録するArrayList
		private static Texture2D Texture;
		private static TextureInfo TextureInfo;
		
		public static void InitItem(){
			ItemList = new ArrayList();
			Texture = new Texture2D("Application/resourses/star.png", false);
			TextureInfo = new TextureInfo(Texture);
		}
		
		/// <summary>
		/// 新しくアイテムを生成
		/// </summary>
		/// <param name='itemType'>
		/// Item type.
		/// </param>
		/// <param name='generatePosition'>
		/// Generate position.
		/// </param>
		public static void NewItem(ItemType itemType, Vector2 generatePosition){
			var newItem = new Item1(itemType);
			
			newItem.Sprite = new SpriteUV(){TextureInfo = TextureInfo};
			newItem.Sprite.Quad.S = TextureInfo.TextureSizef;
			newItem.Sprite.CenterSprite();
			newItem.Sprite.Position = generatePosition;
			ItemList.Add(newItem);
			Scenes.sceneOnGame.AddChild(((Item1)ItemList[ItemList.Count-1]).Sprite);
		}
		
		/// <summary>
		/// アイテムの位置を更新
		/// </summary>
		/// <param name='item'>
		/// Item.
		/// </param>
		public static void Update(Item1 item){
			var newItemPosition = new Vector2(item.Sprite.Position.X,item.Sprite.Position.Y);
			newItemPosition += new Vector2(-2,0);
			item.Sprite.RunAction(new MoveTo(newItemPosition,0.0f));
		}
		
		/// <summary>
		/// アイテムを削除
		/// </summary>
		/// <param name='item'>
		/// Item.
		/// </param>
		public static void removeItem(Item1 item){
			item.Sprite.RemoveAllChildren(true);
			Scenes.sceneOnGame.RemoveChild(item.Sprite,true);
			ItemList.Remove(item);
		}
		
		/// <summary>
		/// アイテムと自機の当たり判定
		/// </summary>
		/// <returns>
		/// The collision detection.
		/// </returns>
		/// <param name='mySpritePosition'>
		/// My sprite position.
		/// </param>
		public static Item1 ItemCollisionDetection(Vector2 mySpritePosition){
			foreach(Item1 item in ItemList){
				if(mySpritePosition.Distance(item.Sprite.Position) < 50){
					return item;
				}
			}
			return null;
		}
	}
}

