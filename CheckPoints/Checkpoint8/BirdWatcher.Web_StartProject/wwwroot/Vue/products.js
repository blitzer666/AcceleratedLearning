const app = new Vue({
    el: "#app",
    data: {
       
       products:[
        
           // { product: "Skiftnyckel", quantity: 5 },
           // { product: "Hammare", quantity: 10 },
           //{ product: "Såg", quantity: 0 },
            ]
      
    },
    computed: {
        totalProducts() {
            let sum = 0;
            for (let p of this.products) {
                if (p.quantity !== "")
                    sum += p.quantity;
            }
            return sum;

        }
    },

    methods: {
        increase: (p) => {
            p.quantity++;

        },
        decrease: (p) => {
            p.quantity--;
            if (p.quantity < 0)
                p.quantity = 0;
        },
        assertPositive: (p) => {

            if (p.quantity === "")
                p.quantity = 0;

            if (p.quantity < 0)
                p.quantity = 0;
        }

    },

    async created() {

        let response = await fetch("/products");
        this.products = await response.json();
        console.log(this.products)

    }
});