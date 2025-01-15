
describe('Portal de login - Aliados', function() {
  beforeEach(function() {
    cy.visit('https://planoaliados.com.br/portal/login')
  })

  it('Fazer login e realizar a verificação se foi feito o login com sucesso', function() {
    cy.get('#model_Login').type("057.484.723-50")
    cy.get('#model_Password').type("654321")
    cy.get('.v-card__actions > button.v-btn').click()
    cy.get('.v-snack__content').should('be.visible')
  });

});