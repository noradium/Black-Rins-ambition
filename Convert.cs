using System;

using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Graphics;

namespace ShootingApp
{
	public static class Convert
	{
		
		/// <summary>
		/// imageからテクスチャを生成
		/// </summary>
		/// <returns>
		/// テクスチャ
		/// </returns>
		/// <param name='image'>
		/// image
		/// </param>
		public static Texture2D CreateTextureFromImage(Image image){
			var texture = new Texture2D(image.Size.Width, image.Size.Height, false,	PixelFormat.Rgba);
			texture.SetPixels(0, image.ToBuffer());
			return texture;
		}
		
		/// <summary>
		/// 文字列からテクスチャ作成
		/// </summary>
		/// <returns>
		/// テクスチャ
		/// </returns>
		/// <param name='text'>
		/// 文字列
		/// </param>
		/// <param name='font'>
		/// フォント
		/// </param>
		/// <param name='argb'>
		/// ARGB
		/// </param>
		public static Texture2D CreateTextureFromText(string text, Font font, uint argb){
			int width = font.GetTextWidth(text, 0, text.Length);
			int height = font.Metrics.Height;
			
			var image = new Image(ImageMode.Rgba, new ImageSize(width,height),new ImageColor(0,0,0,0));	
			
			image.DrawText(text,new ImageColor((int)((argb >> 16) & 0xff),
			                                   (int)((argb >> 8) & 0xff),
			                                   (int)((argb >> 0) & 0xff),
			                                   (int)((argb >> 24) & 0xff)),font,new ImagePosition(0,0));
			
			
			var texture = new Texture2D(width,height,false, PixelFormat.Rgba);
			texture.SetPixels(0, image.ToBuffer());
			
			image.Dispose();
			font.Dispose();
			return texture;
			
		}
	}
}

