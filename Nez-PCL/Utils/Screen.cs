﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Nez
{
	public static class Screen
	{
		static internal GraphicsDeviceManager _graphicsManager;


		internal static void initialize( GraphicsDeviceManager graphicsManager )
		{
			_graphicsManager = graphicsManager;
		}


		public static int backBufferWidth
		{
			get { return _graphicsManager.PreferredBackBufferWidth; }
			set { _graphicsManager.PreferredBackBufferWidth = value; }
		}


		public static int backBufferHeight
		{
			get { return _graphicsManager.PreferredBackBufferHeight; }
			set { _graphicsManager.PreferredBackBufferHeight = value; }
		}


		public static SurfaceFormat preferredBackBufferFormat
		{
			get { return _graphicsManager.PreferredBackBufferFormat; }
			set { _graphicsManager.PreferredBackBufferFormat = value; }
		}


		public static bool synchronizeWithVerticalRetrace
		{
			get { return _graphicsManager.SynchronizeWithVerticalRetrace; }
			set { _graphicsManager.SynchronizeWithVerticalRetrace = value; }
		}


		// defaults to Depth24
		public static DepthFormat preferredDepthStencilFormat
		{
			get { return _graphicsManager.PreferredDepthStencilFormat; }
			set { _graphicsManager.PreferredDepthStencilFormat = value;	}
		}


		public static bool isFullscreen
		{
			get { return _graphicsManager.IsFullScreen; }
			set { _graphicsManager.IsFullScreen = value; }
		}


		public static void applyChanges()
		{
			//_graphicsManager.ApplyChanges();
			Debug.warn( "noop. applyChanges doesnt work properly on OS X. It causes a crash with no stack trace due to a MonoGame bug." );
		}

	}
}
