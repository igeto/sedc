let $container = $('#container');
let recipes = [];

class Recipe {
	constructor(name, origin) {
		this.name = name;
		this.origin = origin;
		this.ingredients = {};
	}
	addIngredient(ingredient) {

	}
}	
$('#container').on('click', '#addRecipe', () => {
	console.log('im clicked');
	recipes.push(new Recipe($('#name').val(), $('#origin').val()));
	// recipes[length - 1].addIngredient
});

let newRecipe = () => {	
	$container.append(
		`<h1>New Recipe</h1>
		<label for='name'>Name: </label> 
		<input id='name' type='text'><br>
		<label for='origin'>Origin:</label>
		<input id='origin' type='text'><br>
		<h3>Ingredients:</h3><br>
		<select>
			<option selected disabled>Ingredients</option>
			<option value="">Milk</option>
			<option value="">Eggs</option>
			<option value="">Flour</option>
			<option value="">Tomatoes</option>
			<option value="">Potatoes</option>
			<option value="">Paprika</option>
			<option value="">White Cheese</option>
			<option value="">Yellow Cheese</option>
			<option value="">Sugar</option>
			<option value="">Oil</option>
			<option value="">Salt</option>
			<option value="">Meat</option>
		</select>
		<input type='number' style='width: 100px'><br />
		<button id='getIngredient'>Add Ingredient</button>
		<button id='addRecipe'>Add Recipe</button> `
	);
};
newRecipe();