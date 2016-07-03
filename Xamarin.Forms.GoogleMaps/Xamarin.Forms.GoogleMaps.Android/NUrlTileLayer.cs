﻿using System;
using Android.Gms.Maps.Model;

namespace Xamarin.Forms.GoogleMaps.Android
{
	internal class NUrlTileLayer : UrlTileProvider
	{
		private Func<int, int, int, Uri> _makeTileUri;

		public NUrlTileLayer(Func<int, int, int, Uri> makeTileUri, int tileSize = 256) : base(tileSize, tileSize)
		{
			_makeTileUri = makeTileUri;
		}

		public override Java.Net.URL GetTileUrl(int x, int y, int zoom)
		{
			var uri = _makeTileUri(x,y,zoom);
			return new Java.Net.URL(uri.AbsoluteUri);
		}
	}
}
