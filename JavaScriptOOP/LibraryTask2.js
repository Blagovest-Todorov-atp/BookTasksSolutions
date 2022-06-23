class Book {
    constructor(title, authorFirstName, authorSecName, price) {
        this.title = title;
        this.authorFirstName = authorFirstName;
        this.authorSecName = authorSecName;
        this.price = price;
    }


    get title() {
        return this._title;
    }

    set title(titleX) {
        if (titleX.length < 3) {
            throw new Error('Title is not valid!');
        }

        this._title = titleX;
    }

    get authorFirstName(){
        return this._authorFirstName;
    }

    set authorFirstName(authorFirst){
         this._authorFirstName = authorFirst;
    }


    get authorSecName(){
        return this._authorSecName;
    }

    set authorSecName(authorSecName){
             if(!isNaN(authorSecName[0])){
                 throw new Error('Authos is not valid!');
             }

             this._authorSecName = authorSecName;
    }

    get price(){
        return this._price.toFixed(1);
    }

    set price(priceOfBook){
         if(priceOfBook <= 0){
              throw new Error("Price is not valid!");
         }

         this._price = priceOfBook;
    }
}

class GoldenEditionBook extends Book{
        constructor(title, authorFirstName, authorSecName, price){
                super(title, authorFirstName, authorSecName, price);
        }

        set price(priceOfBook){
           super.price = 1.3 * priceOfBook;
        }

        get price(){
            return super.price;
        }

}


let book = new Book("JohnyBoy", "Adam", "Hew", 50.15555);
let goldenEditionBook = new GoldenEditionBook("TestBook", "Richard" ,"Todorov", 100.17777);

console.log(`${book.title}, ${book.authorFirstName}, ${book.authorSecName}, ${book.price}\n`);
console.log(`${goldenEditionBook.title}, ${goldenEditionBook.authorFirstName}, ${goldenEditionBook.authorSecName}, ${goldenEditionBook.price}`);
// in JS when we override setter we have to override the getter too