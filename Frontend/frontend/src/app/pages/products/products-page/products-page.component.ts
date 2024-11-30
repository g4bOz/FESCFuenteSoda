import { Component } from '@angular/core';
import { MenuComponent } from "../../../components/menu/menu.component";

@Component({
  selector: 'fnd-products-page',
  standalone: true,
  imports: [MenuComponent],
  templateUrl: './products-page.component.html',
  styleUrl: './products-page.component.scss'
})
export class ProductsPageComponent {

}
