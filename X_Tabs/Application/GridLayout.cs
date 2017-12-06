﻿using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace X_Tabs
{
	public class GridLayout : UICollectionViewFlowLayout
	{
		public GridLayout()
		{
		}

		public override bool ShouldInvalidateLayoutForBoundsChange(CGRect newBounds)
		{
			return true;
		}

		public override UICollectionViewLayoutAttributes LayoutAttributesForItem(NSIndexPath path)
		{
			return base.LayoutAttributesForItem(path);
		}

		public override UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect(CGRect rect)
		{
			return base.LayoutAttributesForElementsInRect(rect);
		}

		//        public override SizeF CollectionViewContentSize {
		//            get {
		//                return CollectionView.Bounds.Size;
		//            }
		//        }
	}
}
