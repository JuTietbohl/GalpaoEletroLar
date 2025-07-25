document.addEventListener("DOMContentLoaded", function () {
    const costInput = document.querySelector('[name="Produto.Custo"]');
    const priceInput = document.querySelector('[name="Produto.Preco"]');
    const numericFields = [
        '[name="Produto.Custo"]',
        '[name="Produto.Preco"]',
        '[name="Produto.Quantidade"]'
    ];

    numericFields.forEach(selector => {
        const input = document.querySelector(selector);
        if (input && parseFloat(input.value) === 0) {
            input.value = '';
        }
    });

    function calculateFinalPrice(cost) {
        const parsedCost = parseFloat(cost);
        if (!isNaN(parsedCost)) {
            const finalPrice = parsedCost * 1.6;
            priceInput.value = finalPrice.toFixed(2);
        } else {
            priceInput.value = ''
        }
    }

    costInput.addEventListener('blur', () => {
        calculateFinalPrice(costInput.value);
    });
});
