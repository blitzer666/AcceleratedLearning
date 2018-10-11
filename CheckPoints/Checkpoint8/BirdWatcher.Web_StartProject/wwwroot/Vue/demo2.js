new Vue({
    el: '#app',
    data: {
        counter: 0,
        myBool: false
    },
    methods: {
        increaseCounter(increaseLimit) {
            if (this.counter < increaseLimit) this.counter++;
        },

    },
    computed: {
        output() {

            if (this.counter > 10 && this.counter < 20) {
                return 'Du har tryckt massa gånger';
            }

            if (this.counter >= 20) {
                return 'Oj! Du har tryckt mer en 20 gånger!';
            }
        }
    }
});