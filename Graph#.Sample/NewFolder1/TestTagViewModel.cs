using Scraper.Models.Logs;

namespace Scraper.ViewModel.Logs
{
    public class TestTagViewModel 
    {
        public string Text { get; }
        public  TestTagViewModelCollection Tags { get; }
        public  TestTag Tag { get; }

        public TestTagViewModel(string text, TestTag tag)
        {
            this.Text = text;
            this.Tag = tag;
        }

        public TestTagViewModel(string text, TestTag tag, TestTagViewModelCollection testTagViewModelCollection)
        {
            this.Text = text;
            this.Tag = tag;
            this.Tags = testTagViewModelCollection;
        }

        public static TestTagViewModelCollection Create()
        {
            TestTagViewModelCollection tags = new TestTagViewModelCollection(){
    new TestTagViewModel("Berekeningen", TestTag.BEREKENINGEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Annuleringskosten", TestTag.BEREKENINGEN_ANNULERINGSKOSTEN),
    new TestTagViewModel("Annuiteit", TestTag.BEREKENINGEN_ANNUITEIT),
    new TestTagViewModel("Bandbreedte", TestTag.BEREKENINGEN_BANDBREEDTE),
    new TestTagViewModel("ESIS", TestTag.BEREKENINGEN_ESIS,
    new TestTagViewModelCollection(){
    new TestTagViewModel("JKP", TestTag.BEREKENINGEN_ESIS_JKP),
    new TestTagViewModel("PPGE", TestTag.BEREKENINGEN_ESIS_PPGE),
}),
    new TestTagViewModel("Inleg", TestTag.BEREKENINGEN_INLEG),
    new TestTagViewModel("Kosten", TestTag.BEREKENINGEN_KOSTEN),
    new TestTagViewModel("Looptijd", TestTag.BEREKENINGEN_LOOPTIJD),
    new TestTagViewModel("Marktwaarde", TestTag.BEREKENINGEN_MARKTWAARDE),
    new TestTagViewModel("Maximale hypotheek", TestTag.BEREKENINGEN_MAXIMALEHYPOTHEEK,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Box 1", TestTag.BEREKENINGEN_MAXIMALEHYPOTHEEK_BOX1),
    new TestTagViewModel("Box 3", TestTag.BEREKENINGEN_MAXIMALEHYPOTHEEK_BOX3),
}),
    new TestTagViewModel("Netto verstrekking", TestTag.BEREKENINGEN_NETTOVERSTREKKING),
    new TestTagViewModel("Premie", TestTag.BEREKENINGEN_PREMIE),
    new TestTagViewModel("Rente", TestTag.BEREKENINGEN_RENTE,
    new TestTagViewModelCollection(){
    new TestTagViewModel("ABK", TestTag.BEREKENINGEN_RENTE_ABK),
    new TestTagViewModel("Hyposkorting opslag", TestTag.BEREKENINGEN_RENTE_HYPOSKORTINGOPSLAG),
    new TestTagViewModel("LBS", TestTag.BEREKENINGEN_RENTE_LBS),
    new TestTagViewModel("Rentecorrectie", TestTag.BEREKENINGEN_RENTE_RENTECORRECTIE),
}),
    new TestTagViewModel("Verstrekkings percentage LTV", TestTag.BEREKENINGEN_VERSTREKKINGSPERCENTAGELTV),
}),
    new TestTagViewModel("Contractanten", TestTag.CONTRACTANTEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Aantal contractanten", TestTag.CONTRACTANTEN_AANTALCONTRACTANTEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("1 contractant", TestTag.CONTRACTANTEN_AANTALCONTRACTANTEN_1CONTRACTANT),
    new TestTagViewModel("2 contractanten", TestTag.CONTRACTANTEN_AANTALCONTRACTANTEN_2CONTRACTANTEN),
    new TestTagViewModel("meer dan 2 contractanten", TestTag.CONTRACTANTEN_AANTALCONTRACTANTEN_MEERDAN2CONTRACTANTEN),
}),
    new TestTagViewModel("Nationaliteit", TestTag.CONTRACTANTEN_NATIONALITEIT,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Bulgaar", TestTag.CONTRACTANTEN_NATIONALITEIT_BULGAAR),
    new TestTagViewModel("Roemeen", TestTag.CONTRACTANTEN_NATIONALITEIT_ROEMEEN),
}),
    new TestTagViewModel("Notifications", TestTag.CONTRACTANTEN_NOTIFICATIONS),
    new TestTagViewModel("Personeel", TestTag.CONTRACTANTEN_PERSONEEL,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Geen personeel", TestTag.CONTRACTANTEN_PERSONEEL_GEENPERSONEEL),
    new TestTagViewModel("Personeel", TestTag.CONTRACTANTEN_PERSONEEL_PERSONEEL),
}),
    new TestTagViewModel("Rekeningen", TestTag.CONTRACTANTEN_REKENINGEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Annuleringrekening", TestTag.CONTRACTANTEN_REKENINGEN_ANNULERINGREKENING),
    new TestTagViewModel("Incassorekening", TestTag.CONTRACTANTEN_REKENINGEN_INCASSOREKENING),
}),
    new TestTagViewModel("Type inkomen", TestTag.CONTRACTANTEN_TYPEINKOMEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Bestendig inkomen", TestTag.CONTRACTANTEN_TYPEINKOMEN_BESTENDIGINKOMEN),
    new TestTagViewModel("Loondienst", TestTag.CONTRACTANTEN_TYPEINKOMEN_LOONDIENST),
    new TestTagViewModel("OIP ondernemen in prive", TestTag.CONTRACTANTEN_TYPEINKOMEN_OIPONDERNEMENINPRIVE),
    new TestTagViewModel("Overige inkomsten", TestTag.CONTRACTANTEN_TYPEINKOMEN_OVERIGEINKOMSTEN),
    new TestTagViewModel("Pensioeninkomen", TestTag.CONTRACTANTEN_TYPEINKOMEN_PENSIOENINKOMEN),
}),
    new TestTagViewModel("Verplichtingen", TestTag.CONTRACTANTEN_VERPLICHTINGEN),
}),
    new TestTagViewModel("Documenten", TestTag.DOCUMENTEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Inkomendestukken", TestTag.DOCUMENTEN_INKOMENDESTUKKEN),
    new TestTagViewModel("OX", TestTag.DOCUMENTEN_OX),
    new TestTagViewModel("Toevoegen automatisch dossierstuk", TestTag.DOCUMENTEN_TOEVOEGENAUTOMATISCHDOSSIERSTUK),
    new TestTagViewModel("Toevoegen handmatig dossierstuk", TestTag.DOCUMENTEN_TOEVOEGENHANDMATIGDOSSIERSTUK),
    new TestTagViewModel("Uitgaandestukken", TestTag.DOCUMENTEN_UITGAANDESTUKKEN),
    new TestTagViewModel("Wijzigen DA", TestTag.DOCUMENTEN_WIJZIGENDA),
}),
    new TestTagViewModel("Interfaces", TestTag.INTERFACES,
    new TestTagViewModelCollection(){
    new TestTagViewModel("BKR", TestTag.INTERFACES_BKR),
    new TestTagViewModel("Document designer", TestTag.INTERFACES_DOCUMENTDESIGNER),
    new TestTagViewModel("HDN", TestTag.INTERFACES_HDN),
    new TestTagViewModel("Hyarchis", TestTag.INTERFACES_HYARCHIS,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Captiva", TestTag.INTERFACES_HYARCHIS_CAPTIVA),
}),
    new TestTagViewModel("Hypos", TestTag.INTERFACES_HYPOS),
    new TestTagViewModel("Klantdomein", TestTag.INTERFACES_KLANTDOMEIN),
    new TestTagViewModel("Management informatie", TestTag.INTERFACES_MANAGEMENTINFORMATIE,
    new TestTagViewModelCollection(){
    new TestTagViewModel("ISI", TestTag.INTERFACES_MANAGEMENTINFORMATIE_ISI),
    new TestTagViewModel("MIM", TestTag.INTERFACES_MANAGEMENTINFORMATIE_MIM),
    new TestTagViewModel("Viewing", TestTag.INTERFACES_MANAGEMENTINFORMATIE_VIEWING),
}),
    new TestTagViewModel("Mandaten", TestTag.INTERFACES_MANDATEN),
    new TestTagViewModel("MIRA", TestTag.INTERFACES_MIRA),
    new TestTagViewModel("NHG", TestTag.INTERFACES_NHG),
    new TestTagViewModel("Portal IM", TestTag.INTERFACES_PORTALIM),
    new TestTagViewModel("Pricetool", TestTag.INTERFACES_PRICETOOL),
    new TestTagViewModel("Sparen", TestTag.INTERFACES_SPAREN),
}),
    new TestTagViewModel("Onderpanden", TestTag.ONDERPANDEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Aantal onderpanden", TestTag.ONDERPANDEN_AANTALONDERPANDEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("1 onderpand", TestTag.ONDERPANDEN_AANTALONDERPANDEN_1ONDERPAND),
    new TestTagViewModel("Meerdere onderpanden", TestTag.ONDERPANDEN_AANTALONDERPANDEN_MEERDEREONDERPANDEN),
}),
    new TestTagViewModel("Energie label", TestTag.ONDERPANDEN_ENERGIELABEL),
    new TestTagViewModel("Erfpacht", TestTag.ONDERPANDEN_ERFPACHT),
    new TestTagViewModel("Kadastrale gegevens", TestTag.ONDERPANDEN_KADASTRALEGEGEVENS),
    new TestTagViewModel("Soort bouw", TestTag.ONDERPANDEN_SOORTBOUW,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Bestaand verbouw", TestTag.ONDERPANDEN_SOORTBOUW_BESTAANDVERBOUW),
    new TestTagViewModel("Bestaande bouw", TestTag.ONDERPANDEN_SOORTBOUW_BESTAANDEBOUW),
    new TestTagViewModel("Nieuwbouw", TestTag.ONDERPANDEN_SOORTBOUW_NIEUWBOUW),
}),
    new TestTagViewModel("Status", TestTag.ONDERPANDEN_STATUS,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Aankoop", TestTag.ONDERPANDEN_STATUS_AANKOOP),
    new TestTagViewModel("In bezit", TestTag.ONDERPANDEN_STATUS_INBEZIT),
    new TestTagViewModel("Verkoop", TestTag.ONDERPANDEN_STATUS_VERKOOP),
}),
    new TestTagViewModel("Taxatie", TestTag.ONDERPANDEN_TAXATIE),
    new TestTagViewModel("Type onderpand", TestTag.ONDERPANDEN_TYPEONDERPAND),
    new TestTagViewModel("Verhuur", TestTag.ONDERPANDEN_VERHUUR),
}),
    new TestTagViewModel("Other", TestTag.OTHER,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Smoketest", TestTag.OTHER_SMOKETEST),
}),
    new TestTagViewModel("Proces", TestTag.PROCES,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Algemeen Workflow proces", TestTag.PROCES_ALGEMEENWORKFLOWPROCES),
    new TestTagViewModel("Beeindiging", TestTag.PROCES_BEEINDIGING),
    new TestTagViewModel("Eerste hypotheek", TestTag.PROCES_EERSTEHYPOTHEEK),
    new TestTagViewModel("Eigen kanaal", TestTag.PROCES_EIGENKANAAL),
    new TestTagViewModel("FGI Rappel", TestTag.PROCES_FGIRAPPEL),
    new TestTagViewModel("Geldstromen boekingen", TestTag.PROCES_GELDSTROMENBOEKINGEN),
    new TestTagViewModel("Herstructureren", TestTag.PROCES_HERSTRUCTUREREN),
    new TestTagViewModel("Intermediair", TestTag.PROCES_INTERMEDIAIR),
    new TestTagViewModel("Meeneem", TestTag.PROCES_MEENEEM),
    new TestTagViewModel("Omzetting", TestTag.PROCES_OMZETTING),
    new TestTagViewModel("OSK", TestTag.PROCES_OSK),
    new TestTagViewModel("Oversluiten", TestTag.PROCES_OVERSLUITEN),
    new TestTagViewModel("Restschuld financiering", TestTag.PROCES_RESTSCHULDFINANCIERING),
    new TestTagViewModel("Uitkoop ex", TestTag.PROCES_UITKOOPEX),
    new TestTagViewModel("Verhoging bovenhands", TestTag.PROCES_VERHOGINGBOVENHANDS),
    new TestTagViewModel("Verhoging onderhands", TestTag.PROCES_VERHOGINGONDERHANDS),
}),
    new TestTagViewModel("Productvormen", TestTag.PRODUCTVORMEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Bijproduct", TestTag.PRODUCTVORMEN_BIJPRODUCT,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Bankgarantie", TestTag.PRODUCTVORMEN_BIJPRODUCT_BANKGARANTIE),
    new TestTagViewModel("Bouwdepot", TestTag.PRODUCTVORMEN_BIJPRODUCT_BOUWDEPOT),
    new TestTagViewModel("ORB", TestTag.PRODUCTVORMEN_BIJPRODUCT_ORB),
    new TestTagViewModel("Overbrugging", TestTag.PRODUCTVORMEN_BIJPRODUCT_OVERBRUGGING),
    new TestTagViewModel("SEPA Mandaten", TestTag.PRODUCTVORMEN_BIJPRODUCT_SEPAMANDATEN),
}),
    new TestTagViewModel("Meeneem", TestTag.PRODUCTVORMEN_MEENEEM,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Bankspaar", TestTag.PRODUCTVORMEN_MEENEEM_BANKSPAAR),
    new TestTagViewModel("ING spaar", TestTag.PRODUCTVORMEN_MEENEEM_INGSPAAR),
    new TestTagViewModel("Spaar PB", TestTag.PRODUCTVORMEN_MEENEEM_SPAARPB),
}),
    new TestTagViewModel("Nieuw", TestTag.PRODUCTVORMEN_NIEUW,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Aflossingsvrij", TestTag.PRODUCTVORMEN_NIEUW_AFLOSSINGSVRIJ),
    new TestTagViewModel("Annuiteit", TestTag.PRODUCTVORMEN_NIEUW_ANNUITEIT),
    new TestTagViewModel("Bankspaar", TestTag.PRODUCTVORMEN_NIEUW_BANKSPAAR),
    new TestTagViewModel("Lineair", TestTag.PRODUCTVORMEN_NIEUW_LINEAIR),
}),
    new TestTagViewModel("Oud", TestTag.PRODUCTVORMEN_OUD,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Aflossingsvrij", TestTag.PRODUCTVORMEN_OUD_AFLOSSINGSVRIJ),
    new TestTagViewModel("Bankspaar", TestTag.PRODUCTVORMEN_OUD_BANKSPAAR),
    new TestTagViewModel("Bankspaar 1", TestTag.PRODUCTVORMEN_OUD_BANKSPAAR1),
    new TestTagViewModel("Beleggen", TestTag.PRODUCTVORMEN_OUD_BELEGGEN),
    new TestTagViewModel("ING spaar", TestTag.PRODUCTVORMEN_OUD_INGSPAAR),
    new TestTagViewModel("Leven", TestTag.PRODUCTVORMEN_OUD_LEVEN),
    new TestTagViewModel("Lineair", TestTag.PRODUCTVORMEN_OUD_LINEAIR),
    new TestTagViewModel("Maatwerk", TestTag.PRODUCTVORMEN_OUD_MAATWERK),
    new TestTagViewModel("Spaar PB", TestTag.PRODUCTVORMEN_OUD_SPAARPB),
}),
    new TestTagViewModel("Watervilla", TestTag.PRODUCTVORMEN_WATERVILLA),
}),
    new TestTagViewModel("Schermvalidaties", TestTag.SCHERMVALIDATIES,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Aanvraag vergelijker", TestTag.SCHERMVALIDATIES_AANVRAAGVERGELIJKER),
    new TestTagViewModel("Akte en afrekening", TestTag.SCHERMVALIDATIES_AKTEENAFREKENING),
    new TestTagViewModel("Beheer inregeling", TestTag.SCHERMVALIDATIES_BEHEERINREGELING),
    new TestTagViewModel("Contractant", TestTag.SCHERMVALIDATIES_CONTRACTANT),
    new TestTagViewModel("Financiering", TestTag.SCHERMVALIDATIES_FINANCIERING),
    new TestTagViewModel("Inkomen", TestTag.SCHERMVALIDATIES_INKOMEN),
    new TestTagViewModel("Nieuwe werkvoorraad", TestTag.SCHERMVALIDATIES_NIEUWEWERKVOORRAAD),
    new TestTagViewModel("Onderpand", TestTag.SCHERMVALIDATIES_ONDERPAND),
    new TestTagViewModel("Overige bestaande kosten", TestTag.SCHERMVALIDATIES_OVERIGEBESTAANDEKOSTEN),
    new TestTagViewModel("Parameterscherm", TestTag.SCHERMVALIDATIES_PARAMETERSCHERM),
    new TestTagViewModel("Parameterwaardes", TestTag.SCHERMVALIDATIES_PARAMETERWAARDES),
    new TestTagViewModel("Proforma", TestTag.SCHERMVALIDATIES_PROFORMA),
    new TestTagViewModel("Start", TestTag.SCHERMVALIDATIES_START),
}),
    new TestTagViewModel("Toetsen", TestTag.TOETSEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Bijzondere bepalingen", TestTag.TOETSEN_BIJZONDEREBEPALINGEN),
    new TestTagViewModel("Businessrules", TestTag.TOETSEN_BUSINESSRULES),
    new TestTagViewModel("Correctheid en compleetheid", TestTag.TOETSEN_CORRECTHEIDENCOMPLEETHEID),
    new TestTagViewModel("Externe toetsen", TestTag.TOETSEN_EXTERNETOETSEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("BKR", TestTag.TOETSEN_EXTERNETOETSEN_BKR),
    new TestTagViewModel("EVA", TestTag.TOETSEN_EXTERNETOETSEN_EVA),
    new TestTagViewModel("FATCA", TestTag.TOETSEN_EXTERNETOETSEN_FATCA),
    new TestTagViewModel("NHG", TestTag.TOETSEN_EXTERNETOETSEN_NHG),
    new TestTagViewModel("SFH", TestTag.TOETSEN_EXTERNETOETSEN_SFH),
    new TestTagViewModel("VIS", TestTag.TOETSEN_EXTERNETOETSEN_VIS),
}),
    new TestTagViewModel("Stukken", TestTag.TOETSEN_STUKKEN,
    new TestTagViewModelCollection(){
    new TestTagViewModel("Kredietwaardigheidsstukken", TestTag.TOETSEN_STUKKEN_KREDIETWAARDIGHEIDSSTUKKEN),
    new TestTagViewModel("Stukken voor finaal akkoord", TestTag.TOETSEN_STUKKEN_STUKKENVOORFINAALAKKOORD),
}),
    new TestTagViewModel("Workflow validaties", TestTag.TOETSEN_WORKFLOWVALIDATIES),
    new TestTagViewModel("FATCA", TestTag.TOETSEN_FATCA),
    new TestTagViewModel("Moraliteits", TestTag.TOETSEN_MORALITEITS),
    new TestTagViewModel("Toegangskader", TestTag.TOETSEN_TOEGANGSKADER),
}),
    };
            return tags;
        }


    }
}