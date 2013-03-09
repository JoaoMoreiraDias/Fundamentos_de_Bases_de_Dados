SELECT     Accao.A_nome, Funcionario.FUNC_nome, Departamento.DEP_nome
FROM         Accao INNER JOIN
                      C_A ON Accao.A_id = C_A.C_A_A_id INNER JOIN
                      Cargo ON C_A.C_A_C_id = Cargo.C_id INNER JOIN
                      Funcionario ON Cargo.C_id = Funcionario.FUNC_cargo INNER JOIN
                      Departamento ON Funcionario.FUNC_DEP_id = Departamento.DEP_id AND Funcionario.FUNC_id = Departamento.DEP_FUNC_id
where DEP_nome='DEP1'
