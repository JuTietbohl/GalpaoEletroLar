function abrirConfirmacaoCadastro() {
  const modalCadastro = bootstrap.Modal.getInstance(document.getElementById('modalCadastro'));
  modalCadastro.hide();

  setTimeout(() => {
    const modalConfirmacao = new bootstrap.Modal(document.getElementById('modalConfirmaCadastro'));
    modalConfirmacao.show();
  }, 200);
}

function prepararExclusao(id, nome) {
  document.getElementById('produtoIdExcluir').value = id;
  document.getElementById('nomeProdutoExcluir').innerText = nome;
}
