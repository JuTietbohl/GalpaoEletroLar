document.addEventListener("DOMContentLoaded", function () {
    const productType = document.getElementById('TipoProduto');
    const productSize = document.getElementById('tamanhoProduto');
    const sizeInput = document.getElementById('tamanhoInput');
    const productVolts = document.getElementById('campoVoltagem');
    const voltsSelect = document.getElementById('voltagemSelect');

    function atualizarCampos() {
        const tipo = productType.value;

        if (tipo === "Eletro") {
            // Mostrar voltagem e tornar obrigatória
            productVolts.classList.remove("d-none");
            voltsSelect.setAttribute("required", "required");

            // Esconder tamanho e limpar
            productSize.classList.add("d-none");
            sizeInput.removeAttribute("required");
            sizeInput.value = "";
        } else if (tipo === "Movel") {
            // Mostrar tamanho e tornar obrigatório
            productSize.classList.remove("d-none");
            sizeInput.setAttribute("required", "required");

            // Esconder voltagem e limpar
            productVolts.classList.add("d-none");
            voltsSelect.removeAttribute("required");
            voltsSelect.value = "";
        } else {
            // Esconder ambos e limpar tudo
            productSize.classList.add("d-none");
            sizeInput.removeAttribute("required");
            sizeInput.value = "";

            productVolts.classList.add("d-none");
            voltsSelect.removeAttribute("required");
            voltsSelect.value = "";
        }
    }

    if (productType) {
        productType.addEventListener("change", atualizarCampos);
        atualizarCampos(); // Executa no carregamento
    }
});