/*
let apiURl = ""
let apiKey = ""

function GetRecipes(recipeName) {
    let resp = await fetch("");
    let result = await resp.json();
    console.log(result)
}
*/

async function GetRecipes(recipeName, id, isAllShow) {
    let recipes = [
        {
            Id: 1,
            name: "Strawberry cake",
            ingredients: ["strawberries", "flour", "sugar"],
            image: "27.jpg"
        },
        {
            Id: 2,
            name: "Salt pie",
            ingredients: ["salt", "pie crust", "filling"],
            image: "28.jpg"
        },
        {
            Id: 3,
            name: "Sweet pie",
            ingredients: ["sugar", "pie crust", "filling"],
            image: "29.jpg"
        },
        {
            Id: 4,
            name: "Biscuit",
            ingredients: ["flour", "butter", "sugar"],
            image: "31.jpg"
        },
        {
            Id: 5,
            name: "Sable",
            ingredients: ["flour", "butter", "sugar"],
            image: "32.jpg"
        },
        {
            Id: 6,
            name: "Kunafa cake",
            ingredients: ["kunafa dough", "sugar syrup", "nuts"],
            image: "34.jpg"
        },
        {
            Id: 7,
            name: "Lotus pancake",
            ingredients: ["pancake batter", "lotus spread"],
            image: "22.jpg"
        },
        {
            Id: 8,
            name: "Kunafa With Mango",
            ingredients: ["kunafa dough", "mango slices", "sugar syrup"],
            image: "14.jpg"
        },
        {
            Id: 9,
            name: "Kunafa mix fresh fruit",
            ingredients: ["kunafa dough", "mixed fresh fruits", "whipped cream"],
            image: "25.jpg"
        }
    ];

    let filteredRecipes = recipes.filter(recipe => recipe.name.toLowerCase().includes(recipeName.toLowerCase()));
    //console.log(filteredRecipes);

    let showResult = isAllShow ? recipes : recipes.slice(0, 5)
    console.log(showResult);
    showRecipes(filteredRecipes, id);
    //showRecipes(filteredRecipes, "recipe-list-container");
}

function showRecipes(recipes, id) {
    $.ajax({
        contentType: 'application/json;charset=utf-8',
        dataType: 'html',
        type: 'POST',
        url: '/Recipe/GetRecipeCard',
        data: JSON.stringify(recipes),
        success: function (htmlResult) {
            $('#' + id).html(htmlResult);
        }
    });
}
