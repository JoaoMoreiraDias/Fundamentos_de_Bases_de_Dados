SELECT     Documento.D_nome, Accao.A_nome, Departamento.DEP_nome
FROM         Accao INNER JOIN
                      D_D_A ON Accao.A_id = D_D_A.D_D_A_A_id INNER JOIN
                      D_D ON D_D_A.D_D_A_D_D_id = D_D.D_D_id INNER JOIN
                      Departamento ON D_D.D_D_DEP_id = Departamento.DEP_id INNER JOIN
                      Documento ON D_D.D_D_D_id = Documento.D_id
where D_nome='Documento1'