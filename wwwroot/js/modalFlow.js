function abrirConfirmacaoCadastro() {
  const modalCadastro = bootstrap.Modal.getInstance(document.getElementById('modalCadastro'));
  modalCadastro.hide();

  setTimeout(() => {
    const modalConfirmacao = new bootstrap.Modal(document.getElementById('modalConfirmaCadastro'));
    modalConfirmacao.show();
  }, 200);
}
