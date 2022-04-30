using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Stripe.Readerupdate
{
    public sealed partial class UpdatePackage
    {

        public unsafe global::System.Collections.IList SubList(int fromIndex, int toIndex)
        {
            return SubListWrap(fromIndex, toIndex) as System.Collections.IList;
        }

    }
}

//namespace Com.Stripe.Core.Paymentcollection
//{
//    public sealed partial class TippingHandler_Factory
//    {
//        public unsafe global::Java.Lang.Object Get()
//        {
//            return this;
//        }
//    }
//}