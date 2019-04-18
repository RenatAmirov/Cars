import { Routes, RouterModule } from "@angular/router";

import { CarTableComponent } from "./structure/carTable.component"

//import { ProductSelectionComponent } from "./store/productSelection.component";
//import { CartDetailComponent } from "./store/cartDetail.component";
//import { CheckoutDetailsComponent }
//    from "./store/checkout/checkoutDetails.component";
//import { CheckoutPaymentComponent }
//    from "./store/checkout/checkoutPayment.component";
//import { CheckoutSummaryComponent }
//    from "./store/checkout/checkoutSummary.component";
//import { OrderConfirmationComponent }
//    from "./store/checkout/orderConfirmation.component";

const routes: Routes = [
  { path: "table", component: CarTableComponent },
  { path: "", component: CarTableComponent }
]

export const RoutingConfig = RouterModule.forRoot(routes);
