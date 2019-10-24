import { Component, OnInit } from '@angular/core';
import { Recipe } from '../recipe.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent {

  recipes: Recipe[] = [

    new Recipe('A test recipe', 'This is just a test recipe...',
      'https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/caponata-pasta_1.jpg'),

    new Recipe('A test recipe 2', 'Second just a test recipe...',
      'https://www.yummyhealthyeasy.com/wp-content/uploads/2019/02/chicken-marsala-recipe-4.jpg')
  ];
}
