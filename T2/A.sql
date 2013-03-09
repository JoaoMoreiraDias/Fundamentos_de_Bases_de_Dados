SELECT     Departamento.DEP_nome, Funcionario.FUNC_nome
FROM         Departamento INNER JOIN
                      Funcionario ON Departamento.DEP_FUNC_id = Funcionario.FUNC_id AND Departamento.DEP_id = Funcionario.FUNC_DEP_id
where DEP_nome='DEP1' 
                     