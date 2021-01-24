import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { SubCategoryComponent } from './subCategory/subCategory.component';
import { UnitMeasureComponent } from './unitMeasure/unitMeasure.component';
import { HNavBarComponent } from './hNavBar/hNavBar.component';

@NgModule({
  declarations: [				
    AppComponent,
      ProductComponent,
      SubCategoryComponent,
      UnitMeasureComponent,
      HNavBarComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
