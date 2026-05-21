# Copy2Esemptia

Eina d'escriptori per automatitzar l'entrada massiva de qualificacions al sistema de gestió acadèmica **Esemptia**.

## Com funciona

Esemptia no permet importar qualificacions directament des d'Excel. Aquesta aplicació simula el tecleig humà: copia les dades, les organitza per columnes i les enganxa automàticament a Esemptia usant la navegació per teclat (TAB, DEL).

## Funcionalitats

- **Columnes dinàmiques** — configura de 1 a 10 columnes en temps d'execució
- **Càrrega des d'Excel** — enganxa dades copiades d'Excel (format TSV) i l'app les distribueix automàticament
- **Esborrat previ** — opció per esborrar el contingut existent a Esemptia abans d'escriure
- **Neteja en finalitzar** — esborra les dades de l'app un cop el procés s'ha completat
- **Ignora darrer intro** — evita enviar una línia buida al final

## Ús

1. Copia les qualificacions des d'Excel
2. Fes clic a **Carrega des d'Excel...** i enganxa les dades
3. Ves a Esemptia i situa't a la primera cel·la on vols escriure
4. Torna a l'app i fes clic a **Enganxar**
5. Tens 5 segons per canviar de finestra

## Requisits

- Windows
- .NET Framework 4.7.2

## Configuració

Els paràmetres es troben a `App.config`:

| Paràmetre    | Descripció                        | Valor per defecte |
|--------------|-----------------------------------|-------------------|
| `Retard`     | Mil·lisegons entre cada tecla     | 200               |
| `MaxColumnes`| Nombre màxim de columnes          | 10                |
