/*
 * Created by SharpDevelop.
 * User: Maciej
 * Date: 02.02.2017
 * Time: 14:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Verse;

namespace Test
{
	internal class CompProperties_SecondLayer : CompProperties
	{
		public GraphicData graphicData;

		public AltitudeLayer altitudeLayer;

		public float Altitude
		{
			get
			{
				return Altitudes.AltitudeFor(this.altitudeLayer);
			}
		}

		public CompProperties_SecondLayer()
		{
			this.compClass = typeof(CompSecondLayer);
		}
	}
}
