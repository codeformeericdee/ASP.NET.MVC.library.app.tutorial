﻿using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);
        IEnumerable<Checkout> GetAll();

        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);
        Checkout GetCheckoutByAssetId(int assetId);

        bool IsCheckedOut(int id);
        DateTime GetCurrentHoldPlaced(int id);
        string GetCurrentCheckoutPatron(int assetId);
        string GetCurrentHoldPatronName(int id);

        void PlaceHold(int assetId, int libraryCardId);
        void Add(Checkout newCheckout);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);
    }
}
