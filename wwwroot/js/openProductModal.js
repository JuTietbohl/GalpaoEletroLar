document.addEventListener("DOMContentLoaded", function () {
    function showModal(html) {
        const modalContainer = document.getElementById('modalContainer');
        modalContainer.innerHTML = html;

        const modalElement = document.getElementById('modalDetalhes');
        const modal = new bootstrap.Modal(modalElement);
        modal.show();

        return modalElement;
    }

    function setupEditButton(modalElement) {
        const editBtn = modalElement.querySelector('#edit-button');
        if (!editBtn) return;

        editBtn.addEventListener('click', function (e) {
            e.preventDefault();

            if (editBtn.textContent === "Salvar") {
                saveProductDetails(editBtn);
            } else {
                enableFormFields(modalElement);
                changeButtonToSave(editBtn);
            }
        });
    }
    function enableFormFields(modalElement) {
        const formElements = modalElement.querySelectorAll('input, select, textarea');
        formElements.forEach(el => {
            el.disabled = false;
        });
    }

    function changeButtonToSave(button) {
        button.textContent = "Salvar";
    }

    async function loadProductDetails(id) {
        try {
            const response = await fetch(`/Catalogo/DetalhesProduto?id=${id}`);
            const html = await response.text();
            const modalElement = showModal(html);
            setupEditButton(modalElement);
        } catch (error) {
            console.error('Erro ao carregar modal:', error);
        }
    }
    function setupDetailsButtons() {
        document.querySelectorAll('.btn-detalhes').forEach(button => {
            button.addEventListener('click', function () {
                const id = this.getAttribute('data-id');
                loadProductDetails(id);
            });
        });
    }

    function getProductDataFromForm() {
        return {
            Id: parseInt(document.querySelector('[name="Id"]').value),
            Nome: document.querySelector('[name="Nome"]').value,
            Tipo: document.querySelector('[name="Tipo"]').value.toUpperCase(),
            Voltagem: document.querySelector('[name="Voltagem"]').value || null,
            DataEntrada: document.querySelector('[name="DataEntrada"]').value,
            Custo: parseFloat(document.querySelector('[name="Custo"]').value),
            Preco: parseFloat(document.querySelector('[name="Preco"]').value),
            Quantidade: parseInt(document.querySelector('[name="Quantidade"]').value),
            EmPromocao: false,
            Tamanho: document.querySelector('[name="Tamanho"]').value || null
        };
    }


    async function saveProductDetails(button) {
        const produto = getProductDataFromForm();
        
        console.log(produto);

        try {
            const response = await fetch("/Catalogo/AlterarProduto", {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(produto)
            });

            const result = await response.json();

            if (result.success) {
                alert("Produto atualizado com sucesso!");
            } else {
                alert("Erro ao atualizar produto: " + result.message);
            }
        } catch (error) {
            console.error("Erro ao enviar atualização:", error);
            alert("Ocorreu um erro ao atualizar o produto.");
        }
    }

    setupDetailsButtons();

});