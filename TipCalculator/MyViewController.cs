using System;
using CoreGraphics;
using UIKit;

namespace TipCalculator
{
	public class MyViewController: UIViewController
    {
		public MyViewController()
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.View.BackgroundColor = UIColor.Yellow;
        }
    }
}


