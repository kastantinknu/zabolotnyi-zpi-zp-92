ALTER TABLE Players ADD CONSTRAINT fk_teamid FOREIGN KEY (TeamId) REFERENCES Teams(Id);