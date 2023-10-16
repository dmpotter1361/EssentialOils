Imports System.Net
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.Claims
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Module Notes

    Public Function fnScentTop(e As String)
        Dim scentTop As New Dictionary(Of String, String)()
        scentTop.Add("Basil", "Basil essential oil is a volatile oil extracted from the leaves and flowering tops of the basil plant. It has a warm, sweet, and herbaceous aroma and is often used in aromatherapy, cosmetics, and culinary applications.

Basil essential oil is rich in linalool, an antibacterial, antifungal, and anti-inflammatory compound. It is also a good source of other nutrients, such as vitamin C, magnesium, and iron.

Basil essential oil has some potential benefits, including:

• Promoting relaxation and reducing stress: Basil essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Improving digestion: Basil essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Relieving pain and inflammation: Basil essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Boosting the immune system: Basil essential oil's antibacterial and antifungal properties can help to boost the immune system and protect the body from infection.

Basil essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse basil essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of basil essential oil to your bath or shower.
• Topical application: Mix a few drops of basil essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of basil essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Basil essential oil can flavor food and drinks. Be sure to use a minimal amount, as basil essential oil is very concentrated.

It is important to note that basil essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute basil essential oil before using it and avoid eye contact. If you are pregnant, breastfeeding, or have any underlying health conditions, it is important to talk to your doctor before using basil essential oil.")
        scentTop.Add("Bergamot", "Bergamot essential oil is a volatile oil extracted from the rind of the bergamot orange fruit. It has a fresh, citrusy aroma with a hint of floral sweetness. Bergamot essential oil is often used in aromatherapy, cosmetics, and perfumes.

Bergamot essential oil is rich in limonene, linalyl acetate, and bergapten, which are compounds with various potential health benefits. These compounds have been shown to have antibacterial, antifungal, anti-inflammatory, and soothing properties.

Bergamot essential oil has several potential benefits, including:

• Promoting relaxation and reducing stress: Bergamot essential oil's calming and uplifting aroma can help to reduce anxiety and stress. It is also often used to promote sleep.
• Improving skin health: Bergamot essential oil's antibacterial and antifungal properties can help to treat acne, eczema, and other skin conditions. It can also help to reduce the appearance of scars and wrinkles.
• Boosting the immune system: Bergamot essential oil's antimicrobial properties can help to boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Bergamot essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.

Bergamot essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse bergamot essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of bergamot essential oil to your bath or shower.
• Topical application: Mix a few drops of bergamot essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of bergamot essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Bergamot essential oil can add flavor to food and drinks. Be sure to use a tiny amount, as bergamot essential oil is very concentrated.

It is important to note that bergamot essential oil is a concentrated oil and can be irritating to the skin and mucous membranes. It is always important to dilute bergamot essential oil before using it and to avoid contact with the eyes. Bergamot essential oil is also phototoxic, which means that it can make the skin more sensitive to the sun. If you are pregnant, breastfeeding, or have any underlying health conditions, it is important to talk to your doctor before using bergamot essential oil.")
        scentTop.Add("Citronella", "Citronella essential oil is a volatile oil extracted from the leaves and stems of the citronella plant. It has a strong, citrusy aroma and is often used as a natural insect repellent. Citronella essential oil is also used in aromatherapy, cosmetics, and perfumes.

Citronella essential oil is rich in citronellal, citronellol, and geraniol, with various potential health benefits. These compounds have been shown to have antibacterial, antifungal, anti-inflammatory, and insecticidal properties.

Citronella essential oil has a number of potential benefits, including:

• Repelling insects: Citronella essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay.
• Improving skin health: Citronella essential oil's antibacterial and antifungal properties can help to treat acne, eczema, and other skin conditions. It can also help to reduce the appearance of scars and wrinkles.
• Relieving pain and inflammation: Citronella essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Boosting the immune system: Citronella essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.

Citronella essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse citronella essential oil into the air to repel insects and enjoy its refreshing aroma. Add a few drops of citronella essential oil to your bath or shower.
• Topical application: Mix a few drops of citronella essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of citronella essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Citronella essential oil can be used to add flavor to food and drinks. Be sure to use a minimal amount, as citronella essential oil is very concentrated.

It is important to note that citronella essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute citronella essential oil before using it and to avoid contact with the eyes. Citronella essential oil is also generally considered safe for pregnant and breastfeeding women, but it is always best to talk to your doctor before using any essential oil.")
        scentTop.Add("Eucalyptus", "Eucalyptus essential oil is a volatile oil extracted from the leaves of the eucalyptus tree. It has a robust and camphor-like aroma and is often used in aromatherapy, cosmetics, and medicinal products.

Eucalyptus essential oil is rich in eucalyptol, also known as 1,8-cineole, a compound with various potential health benefits. Eucalyptol has been shown to have antibacterial, antifungal, anti-inflammatory, and expectorant properties.

Eucalyptus essential oil has many potential benefits, including:

• Relieving respiratory problems: Eucalyptus essential oil's expectorant properties can help to loosen mucus and relieve congestion caused by bronchitis, asthma, and other respiratory infections.
• Boosting the immune system: Eucalyptus essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Eucalyptus essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Eucalyptus essential oil's antibacterial and antifungal properties can help to treat acne, eczema, and other skin conditions.

Eucalyptus essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse eucalyptus essential oil into the air to clear congestion and relieve respiratory problems. Add a few drops of eucalyptus essential oil to your bath or shower.
• Topical application: Mix a few drops of eucalyptus essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of eucalyptus essential oil to your shampoo, conditioner, or moisturizer.
• Internal use: Eucalyptus essential oil can be taken internally, but this should only be done under the supervision of a qualified healthcare professional.

It is important to note that eucalyptus essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute eucalyptus essential oil before using it and to avoid contact with the eyes. Eucalyptus essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using eucalyptus essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentTop.Add("Grapefruit", "Grapefruit essential oil is a volatile oil extracted from the peel of the grapefruit fruit. It has a fresh, citrusy aroma and is often used in aromatherapy, cosmetics, and food flavoring.

Grapefruit essential oil is rich in limonene, a compound with antibacterial, antifungal, and antioxidant properties. It is also a good source of vitamin C and other nutrients.

Grapefruit essential oil has many potential benefits, including:

• Promoting relaxation and reducing stress: Grapefruit essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Boosting the immune system: Grapefruit essential oil's high vitamin C content and antioxidant properties can help to boost the immune system and protect the body from infection.
• Improving digestion: Grapefruit essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Relieving pain and inflammation: Grapefruit essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Weight loss: Grapefruit essential oil is sometimes used to aid weight loss. However, there is limited scientific evidence to support this claim.

Grapefruit essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse grapefruit essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of grapefruit essential oil to your bath or shower.
• Topical application: Mix a few drops of grapefruit essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of grapefruit essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Grapefruit essential oil can flavor food and drinks. Be sure to use a minimal amount, as grapefruit essential oil is very concentrated.

It is important to note that grapefruit essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute grapefruit essential oil before using it and avoid eye contact. Grapefruit essential oil can also interact with certain medications, so it is important to talk to your doctor before using it if you are taking any medications.

If you are considering using grapefruit essential oil, it is crucial to research and choose a high-quality product. It would help if you also started with a small amount to test your tolerance and avoid using it on sensitive skin areas.")
        scentTop.Add("Lavender", "Lavender essential oil is a volatile oil extracted from the flowers of the lavender plant. It has a sweet, floral aroma and is often used in aromatherapy, cosmetics, and medicinal products.

Lavender essential oil is rich in linalool and linalyl acetate, compounds with various potential health benefits. These compounds have been shown to have antibacterial, antifungal, anti-inflammatory, and soothing properties.

Lavender essential oil has some potential benefits, including:

• Promoting relaxation and reducing stress: Lavender essential oil's calming and uplifting aroma can help to reduce anxiety and stress. It is also often used to promote sleep.
• Relieving pain and inflammation: Lavender essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Lavender essential oil's antibacterial and antifungal properties can help to treat acne, eczema, and other skin conditions.
• Boosting the immune system: Lavender essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.

Lavender essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse lavender essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of lavender essential oil to your bath or shower.
• Topical application: Mix a few drops of lavender essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. You can also add a few drops of lavender essential oil to your shampoo, conditioner, or moisturizer.
• Internal use: Lavender essential oil can be taken internally, but this should only be done under the supervision of a qualified healthcare professional.

Lavender essential oil is generally safe for most people to use. However, it is important to note that it can irritate the skin and mucous membranes. It is always important to dilute lavender essential oil before using it and avoid eye contact. Lavender essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using lavender essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentTop.Add("Lemon", "Lemon essential oil is a volatile oil extracted from the peel of the lemon fruit. It has a fresh, citrusy aroma and is often used in aromatherapy, cosmetics, and cleaning products.

Lemon essential oil is rich in limonene, an antibacterial, antifungal, and antioxidant compound. It is also a good source of vitamin C and other nutrients.

Lemon essential oil has many potential benefits, including:

• Promoting relaxation and reducing stress: Lemon essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Boosting the immune system: Lemon essential oil's high vitamin C content and antioxidant properties can help to boost the immune system and protect the body from infection.
• Improving digestion: Lemon essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Relieving pain and inflammation: Lemon essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Cleaning and disinfecting: Lemon essential oil has antibacterial and antifungal properties, so it can be used to clean and disinfect surfaces.

Lemon essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse lemon essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of lemon essential oil to your bath or shower.
• Topical application: Mix a few drops of lemon essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of lemon essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Lemon essential oil can flavor food and drinks. Be sure to use a minimal amount, as lemon essential oil is very concentrated.
• Cleaning: Lemon essential oil can be added to water to clean surfaces. You can add a few drops of lemon essential oil to your laundry or dishwasher detergent.

It is important to note that lemon essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute lemon essential oil before using it and avoid eye contact. Lemon essential oil is also phototoxic, which means that it can make the skin more sensitive to the sun. Suppose you are pregnant, breastfeeding, or have any underlying health conditions. In that case, talking to your doctor before using lemon essential oil is necessary.

Suppose you are considering using lemon essential oil. In that case, it is crucial to research and choose a high-quality product. It would be best if you also started with a small amount to test your tolerance and avoid using it on sensitive skin areas.")
        scentTop.Add("Lemongrass", "Lemongrass essential oil is a volatile oil extracted from the leaves of the lemongrass plant. It has a fresh, citrusy aroma with a hint of grassy sweetness. Lemongrass essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Lemongrass essential oil is rich in citral, a compound with various potential health benefits. Citral has been shown to have antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Lemongrass essential oil has several potential benefits, including:

• Promoting relaxation and reducing stress: Lemongrass essential oil's calming and uplifting aroma can help to reduce anxiety and stress. It is also often used to promote sleep.
• Relieving pain and inflammation: Lemongrass essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Lemongrass essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Boosting the immune system: Lemongrass essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Repelling insects: Lemongrass essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay.

Lemongrass essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse lemongrass essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of lemongrass essential oil to your bath or shower.
• Topical application: Mix a few drops of lemongrass essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of lemongrass essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Lemongrass essential oil can be used to add flavor to food and drinks. Be sure to use a minimal amount, as lemongrass essential oil is very concentrated.

It is important to note that lemongrass essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute lemongrass essential oil before using it and avoid eye contact. Lemongrass essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using lemongrass essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentTop.Add("Lime", "Lime essential oil is a volatile oil extracted from the rind of the lime fruit. It has a fresh, citrusy aroma and is often used in aromatherapy, cosmetics, and cleaning products.

Lime essential oil is rich in limonene, an antibacterial, antifungal, and antioxidant compound. It is also a good source of vitamin C and other nutrients.

Lime essential oil has some potential benefits, including:

• Promoting relaxation and reducing stress: Lime essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Boosting the immune system: Lime essential oil's high vitamin C content and antioxidant properties can help to boost the immune system and protect the body from infection.
• Improving skin health: Lime essential oil's antibacterial and antifungal properties can help to treat acne, eczema, and other skin conditions. It can also help to brighten the skin and reduce the appearance of dark spots.
•  Relieving pain and inflammation: Lime essential oil has anti-inflammatory and analgesic properties that can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.

Lime essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse lime essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of lime essential oil to your bath or shower.
• Topical application: Mix a few drops of lime essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of lime essential oil to your shampoo, conditioner, or moisturizer.
• Internal use: Lime essential oil can be taken internally, but this should only be done under the supervision of a qualified healthcare professional.
• It is important to note that lime essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute lime essential oil before using it and to avoid contact with the eyes.")
        scentTop.Add("Petitgrain", "Petitgrain essential oil is a volatile oil extracted from the leaves and green twigs of the bitter orange tree (Citrus aurantium ssp. amara). It has a fresh, citrusy scent with woody-herbaceous undertones. Petitgrain essential oil is often used in perfumery and aromatherapy and has a variety of potential health benefits.

Some of the potential benefits of petitgrain essential oil include:

• Promoting relaxation and reducing stress: Petitgrain essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Relieving pain and inflammation: Petitgrain essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Petitgrain essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Boosting the immune system: Petitgrain essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Improving skin health: Petitgrain essential oil's antibacterial and antifungal properties can help treat acne, eczema, and other skin conditions.

Petitgrain essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse petitgrain essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of petitgrain essential oil to your bath or shower.
• Topical application: Mix a few drops of petitgrain essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. You can also add a few drops of petitgrain essential oil to your shampoo, conditioner, or moisturizer.
• Massage: Petitgrain essential oil can be used in massage to relieve muscle tension and promote relaxation.

It is important to note that petitgrain essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute petitgrain essential oil before using it and to avoid contact with the eyes. Petitgrain essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using petitgrain essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentTop.Add("Pine Needle", "Pine needle essential oil is a volatile oil extracted from the needles of various pine trees, such as Pinus sylvestris and Pinus mugo. It has a strong, refreshing, and balsamic aroma often associated with Christmas trees. Pine needle essential oil is often used in aromatherapy, cosmetics, and cleaning products.

Pine needle essential oil is rich in monoterpenes, such as alpha-pinene and beta-pinene, which are compounds with a variety of potential health benefits. Monoterpenes have been shown to have antibacterial, antifungal, anti-inflammatory, and expectorant properties.

Pine needle essential oil has several potential benefits, including:

• Promoting relaxation and reducing stress: Pine needle essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Relieving respiratory problems: Pine needle essential oil's expectorant properties can help to loosen mucus and relieve congestion caused by bronchitis, asthma, and other respiratory infections.
• Boosting the immune system: Pine needle essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Pine needle essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.

Pine needle essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse pine needle essential oil into the air to enjoy its calming and refreshing aroma. You can also add a few drops of pine needle essential oil to your bath or shower.
• Topical application: Mix a few drops of pine needle essential oil with carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of pine needle essential oil to your shampoo, conditioner, or moisturizer.
• Massage: Pine needle essential oil can be used in massage to relieve muscle tension and promote relaxation.

It is important to note that pine needle essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute pine needle essential oil before using it and avoid eye contact. Pine needle essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using pine needle essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentTop.Add("Sage", "Sage essential oil is a volatile oil extracted from the leaves of the sage plant (Salvia officinalis). It has a strong, herbaceous aroma with a slightly camphoraceous undertone. Sage essential oil is often used in aromatherapy, cosmetics, and medicinal products.

Sage essential oil is rich in thujone, which has antibacterial, antifungal, and anti-inflammatory properties. It is also a good source of other beneficial compounds, such as cineole, camphor, and rosmarinic acid.

Sage essential oil has several potential health benefits, including:

• Promoting relaxation and reducing stress: Sage essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Improving digestion: Sage essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Relieving pain and inflammation: Sage essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Boosting the immune system: Sage essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Improving oral health: Sage essential oil's antibacterial and antifungal properties can help to treat gum disease and other oral infections.

Sage essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse sage essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of sage essential oil to your bath or shower.
• Topical application: Mix a few drops of sage essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of sage essential oil to your shampoo, conditioner, or moisturizer.
• Oral rinse: Add a few drops of sage essential oil to a glass of water and use it as an oral rinse to freshen breath and reduce gum inflammation.

It is important to note that sage essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute sage essential oil before using it and avoid eye contact. Sage essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using sage essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentTop.Add("Spearmint", "Spearmint essential oil is a volatile oil extracted from the leaves and stems of the spearmint plant (Mentha spicata). It has a fresh, minty aroma with a slightly sweet undertone. Spearmint essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Spearmint essential oil is rich in carvone, a compound with antibacterial, antifungal, and anti-inflammatory properties. It is also a good source of other beneficial compounds, such as limonene, cineole, and menthol.

Spearmint essential oil has some potential health benefits, including:

• Promoting relaxation and reducing stress: Spearmint essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Improving digestion: Spearmint essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Relieving pain and inflammation: Spearmint essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Boosting the immune system: Spearmint essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Fresh breath: Spearmint essential oil is often used in toothpaste and mouthwash because of its refreshing minty aroma and its ability to freshen breath.

Spearmint essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse spearmint essential oil into the air to enjoy its calming and uplifting aroma. You can also add a few drops of spearmint essential oil to your bath or shower.
• Topical application: Mix a few drops of spearmint essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of spearmint essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Spearmint essential oil can be used to add flavor to food and drinks. Be sure to use a tiny amount, as spearmint essential oil is very concentrated.

It is important to note that spearmint essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute spearmint essential oil before using it and avoid eye contact. Spearmint essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using spearmint essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentTop.Add("Sweet Orange", "Sweet orange essential oil is a volatile oil extracted from the rind of the sweet orange fruit (Citrus sinensis). It has a bright, citrusy aroma with a slightly sweet undertone. Sweet orange essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Sweet orange essential oil is rich in limonene, an antibacterial, antifungal, and antioxidant compound. It is also a good source of other beneficial compounds, such as linalool and myrcene.

Sweet orange essential oil has several potential health benefits, including:

• Promoting relaxation and reducing stress: Sweet orange essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Improving mood: Sweet orange essential oil has been shown to improve mood and reduce feelings of depression.
• Boosting the immune system: Sweet orange essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Sweet orange essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Sweet orange essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.

Sweet orange essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse sweet orange essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of sweet orange essential oil to your bath or shower.
• Topical application: Mix a few drops of sweet orange essential oil with a carrier oil, such as coconut oil or jojoba oil, and apply it to the skin. Add a few drops of sweet orange essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Sweet orange essential oil can be used to add flavor to food and drinks. Be sure to use a minimal amount, as sweet orange essential oil is very concentrated.

It is important to note that sweet orange essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute sweet orange essential oil before using it and avoid eye contact. Sweet orange essential oil is also phototoxic, which means that it can make the skin more sensitive to the sun. Suppose you are pregnant or breastfeeding or have any underlying health conditions. In that case, talking to your doctor before using sweet orange essential oil is necessary.

Suppose you are considering using sweet orange essential oil. In that case, it is important to research and choose a high-quality product. It would help if you also started with a small amount to test your tolerance and avoid using it on sensitive skin areas.")
        If scentTop.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnScentMiddle(e As String)
        Dim scentMiddle As New Dictionary(Of String, String)
        scentMiddle.Add("Black Pepper", "Black pepper essential oil is a volatile oil extracted from the dried and crushed peppercorns of the Piper nigrum plant. It has a warm, spicy, and woody aroma. Black pepper essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Black pepper essential oil is rich in monoterpenes, such as alpha-pinene and beta-pinene, and sesquiterpenes, such as caryophyllene. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Black pepper essential oil has several potential health benefits, including:

• Boosting the immune system: Black pepper essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Black pepper essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Black pepper essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Repelling insects: Black pepper essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay.

Black pepper essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse black pepper essential oil into the air to enjoy its warm and spicy aroma. Add a few drops of black pepper essential oil to your bath or shower.
• Topical application: Mix a few drops of black pepper essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of black pepper essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Black pepper essential oil can flavor food and drinks. Be sure to use a minimal amount, as black pepper essential oil is very concentrated.

It is important to note that black pepper essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute black pepper essential oil before using it and avoid eye contact. Black pepper essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using black pepper essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Cinnamon Leaf", "Cinnamon leaf essential oil is a volatile oil extracted from the leaves of the cinnamon tree, Cinnamomum verum. It has a warm, spicy, and slightly sweet aroma. Cinnamon leaf essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Cinnamon leaf essential oil is rich in eugenol, a compound with antibacterial, antifungal, and anti-inflammatory properties. It is also a good source of other beneficial compounds, such as cinnamaldehyde, linalool, and myrcene.

Cinnamon leaf essential oil has some potential health benefits, including:

• Boosting the immune system: Cinnamon leaf essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Cinnamon leaf essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Cinnamon leaf essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Relieving respiratory problems: Cinnamon leaf essential oil's expectorant properties can help to loosen mucus and relieve congestion caused by bronchitis, asthma, and other respiratory infections.
• Improving oral health: Cinnamon leaf essential oil's antibacterial and antifungal properties can help to treat gum disease and other oral infections.

Cinnamon leaf essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse cinnamon leaf essential oil into the air to enjoy its warm and spicy aroma. Add a few drops of cinnamon leaf essential oil to your bath or shower.
• Topical application: Mix a few drops of cinnamon leaf essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of cinnamon leaf essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Cinnamon leaf essential oil can flavor food and drinks. Be sure to use a tiny amount, as cinnamon leaf essential oil is very concentrated.

It is important to note that cinnamon leaf essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute cinnamon leaf essential oil before using it and avoid eye contact. Cinnamon leaf essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using cinnamon leaf essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Citronella", "Citronella essential oil is a volatile oil extracted from the leaves and stems of different species of Cymbopogon, such as Cymbopogon nardus and Cymbopogon winterianus. It has a strong, citrusy aroma with a slightly grassy undertone. Citronella essential oil is often used in aromatherapy, cosmetics, and insect repellents.

Citronella essential oil is rich in citronellal, citronellol, and geraniol. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and insect-repellent properties.

Citronella essential oil has many potential health benefits, including:

• Repelling insects: Citronella essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay. It is thought to work by masking scents that are attractive to insects.
• Relieving pain and inflammation: Citronella essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Citronella essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Boosting the immune system: Citronella essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.

Citronella essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse citronella essential oil into the air to enjoy its fresh and citrusy aroma. You can also add a few drops of citronella essential oil to your bath or shower.
• Topical application: Mix a few drops of citronella essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Add a few drops of citronella essential oil to your shampoo, conditioner, or moisturizer.
• Insect repellent: Apply citronella essential oil and carrier oil to your skin to repel insects. You can also add a few drops of citronella essential oil to your diffuser or a spray bottle of water around your home.

It is important to note that citronella essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute citronella essential oil before using it and to avoid contact with the eyes. Citronella essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using citronella essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Coriander", "Coriander essential oil is a volatile oil extracted from the seeds of the coriander plant, Coriandrum sativum. It has a warm, spicy, and slightly citrusy aroma. Coriander essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Coriander essential oil is rich in linalool, a compound with antibacterial, antifungal, and anti-inflammatory properties. It is also a good source of other beneficial compounds, such as pinene, camphor, and borneol.

Coriander essential oil has several potential health benefits, including:

• Improving digestion: Coriander essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Boosting the immune system: Coriander essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Coriander essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Reducing stress and anxiety: Coriander essential oil's calming and uplifting aroma can help to reduce stress and anxiety. It can also help to promote sleep.

Coriander essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse coriander essential oil into the air to enjoy its warm and spicy aroma. You can also add a few drops of coriander essential oil to your bath or shower.
• Topical application: Mix a few drops of coriander essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Add a few drops of coriander essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Coriander essential oil can be used to add flavor to food and drinks. Be sure to use a minimal amount, as coriander essential oil is very concentrated.

It is important to note that coriander essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute coriander essential oil before using it and avoid eye contact. Coriander essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using coriander essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Clove", "Clove essential oil is a volatile oil extracted from the dried flower buds of the clove tree, Syzygium aromaticum. It has a strong, spicy, and slightly sweet aroma. Clove essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Clove essential oil is rich in eugenol, an antibacterial, antifungal, anti-inflammatory, and analgesic compound. It is also a good source of other beneficial compounds, such as beta-caryophyllene and alpha-humulene.

Clove essential oil has some potential health benefits, including:

• Relieving pain and inflammation: Clove essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving oral health: Clove essential oil's antibacterial and antifungal properties can help to treat gum disease, toothaches, and other oral infections.
• Boosting the immune system: Clove essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Improving digestion: Clove essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Reducing stress and anxiety: Clove essential oil's calming and uplifting aroma can help to reduce stress and anxiety. It can also help to promote sleep.

Clove essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse clove essential oil into the air to enjoy its strong and spicy aroma. You can also add a few drops of clove essential oil to your bath or shower.
• Topical application: Mix a few drops of clove essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. You can also add a few drops of clove essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Clove essential oil can flavor food and drinks. Be sure to use a tiny amount, as clove essential oil is very concentrated.

It is important to note that clove essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute clove essential oil before using it and avoid eye contact. Clove essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using clove essential oil, it is important to talk to your doctor first to ensure it is safe.

Here are some additional safety tips for using clove essential oil:

• Do not use clove essential oil internally.
• Do not use clove essential oil undiluted on the skin.
• Avoid contact with the eyes.
• Do not use clove essential oil on children under the age of 6.
• If you are pregnant or breastfeeding, talk to your doctor before using clove essential oil.
• If you have any underlying health conditions, talk to your doctor before using clove essential oil.

Clove essential oil is a powerful essential oil with a variety of potential health benefits. However, it is vital to use it safely and responsibly.")
        scentMiddle.Add("Cypress", "Cypress essential oil is a volatile oil extracted from the needles and leaves, or wood and bark, of select cypress tree species. It has a fresh, herbaceous, woody, and slightly coniferous aroma. Cypress essential oil is often used in aromatherapy, cosmetics, and massage therapy.

Cypress essential oil is rich in monoterpenes, such as alpha-pinene and carene, and sesquiterpenes, such as caryophyllene. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Cypress essential oil has many potential health benefits, including:

• Reducing pain and inflammation: Cypress essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving respiratory function: Cypress essential oil's expectorant properties can help to loosen mucus and relieve congestion caused by bronchitis, asthma, and other respiratory infections.
• Boosting the immune system: Cypress essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving stress and anxiety: Cypress essential oil's calming and uplifting aroma can help to reduce stress and anxiety. It can also help to promote sleep.

Cypress essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse cypress essential oil into the air to enjoy its fresh and herbaceous aroma. You can also add a few drops of cypress essential oil to your bath or shower.
• Topical application: Mix a few drops of cypress essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Add a few drops of cypress essential oil to your shampoo, conditioner, or moisturizer.
• Massage: Cypress essential oil can be used in massage to relieve muscle tension and promote relaxation.

It is important to note that cypress essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute cypress essential oil before using it and avoid eye contact. Cypress essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using cypress essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Chamomile", "Chamomile essential oil is a volatile oil extracted from the flowers of the chamomile plant, Chamaemelum nobile or Matricaria recutita. It has a sweet, floral, and slightly apple-like aroma. Chamomile essential oil is often used in aromatherapy, cosmetics, and massage therapy.

Chamomile essential oil is rich in chamazulene and alpha-bisabolol, compounds with anti-inflammatory, calming, and soothing properties. It is also a good source of other beneficial compounds, such as sesquiterpenes, monoterpenes, and esters.

Chamomile essential oil has several potential health benefits, including:

• Reducing stress and anxiety: Chamomile essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Chamomile essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Chamomile essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Boosting the immune system: Chamomile essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Improving skin health: Chamomile essential oil's anti-inflammatory and soothing properties can help to treat skin conditions such as eczema, psoriasis, and acne.

Chamomile essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse chamomile essential oil into the air to enjoy its calming and relaxing aroma. You can also add a few drops of chamomile essential oil to your bath or shower.
• Topical application: Mix a few drops of chamomile essential oil with a carrier oil, such as coconut oil or jojoba oil, and apply it to the skin. You can also add a few drops of chamomile essential oil to your shampoo, conditioner, or moisturizer.
• Massage: Chamomile essential oil can be used in massage to relieve muscle tension and promote relaxation.

It is important to note that chamomile essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute chamomile essential oil before using it and avoid eye contact. Chamomile essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using chamomile essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Clary Sage", "Clary sage essential oil is a volatile oil extracted from the leaves and flowers of the clary sage plant (Salvia sclarea). It has a warm, herbaceous, and slightly musky aroma. Clary sage essential oil is often used in aromatherapy, cosmetics, and massage therapy.

Clary sage essential oil is rich in linalyl acetate and sclareol, with anti-inflammatory, calming, and relaxing properties. It is also a good source of other beneficial compounds, such as monoterpenes, sesquiterpenes, and esters.

Clary sage essential oil has some potential health benefits, including:

• Reducing stress and anxiety: Clary sage essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Clary sage essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Boosting the immune system: Clary sage essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Improving skin health: Clary sage essential oil's anti-inflammatory and soothing properties can help to treat skin conditions such as eczema, psoriasis, and acne.
• Regulating hormones: Clary sage essential oil is thought to help regulate hormones, which can be beneficial for women's health. It may help to relieve menstrual cramps, premenstrual syndrome (PMS), and menopausal symptoms.

Clary sage essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse clary sage essential oil into the air to enjoy its calming and relaxing aroma. You can also add a few drops of clary sage essential oil to your bath or shower.
• Topical application: Mix a few drops of clary sage essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. You can also add a few drops of clary sage essential oil to your shampoo, conditioner, or moisturizer.
• Massage: Clary sage essential oil can be used in massage to relieve muscle tension and promote relaxation.

It is important to note that clary sage essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute clary sage essential oil before using it and to avoid contact with the eyes. Clary sage essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using clary sage essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Geranium", "Geranium essential oil is a volatile oil extracted from the leaves of the geranium plant (Pelargonium graveolens). It has a sweet, floral aroma with a slightly citrusy undertone. Geranium essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Geranium essential oil is rich in monoterpenes, such as citronellol and geraniol, and esters, such as citronellyl acetate and geranyl acetate. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Geranium essential oil has many potential health benefits, including:

• Reducing stress and anxiety: Geranium essential oil's calming and uplifting aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Geranium essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Geranium essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as eczema, psoriasis, and acne.
• Boosting the immune system: Geranium essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Improving digestion: Geranium essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.

Geranium essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse geranium essential oil into the air to enjoy its sweet and floral aroma. You can also add a few drops of geranium essential oil to your bath or shower.
• Topical application: Mix a few drops of geranium essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. You can also add a few drops of geranium essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Geranium essential oil can be used to add flavor to food and drinks. Be sure to use a minimal amount, as geranium essential oil is very concentrated.

It is important to note that geranium essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute geranium essential oil before using it and avoid eye contact. Geranium essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using geranium essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Juniper Berry", "Juniper berry essential oil is a volatile oil extracted from the berries of the juniper plant (Juniperus communis). It has a fresh, woody, and slightly camphoraceous aroma. Juniper berry essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Juniper berry essential oil is rich in monoterpenes, such as alpha-pinene and beta-pinene, and sesquiterpenes, such as caryophyllene. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Juniper berry essential oil has several potential health benefits, including:

• Boosting the immune system: Juniper berry essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Juniper berry essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Juniper berry essential oil can help relieve digestive problems such as indigestion, gas, and bloating.
• Repelling insects: Juniper berry essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay.
• Juniper berry essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse juniper berry essential oil into the air to enjoy its fresh and woody aroma. You can also add a few drops of juniper berry essential oil to your bath or shower.
• Topical application: Mix a few drops of juniper berry essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. You can also add a few drops of juniper berry essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Juniper berry essential oil can be used to add flavor to food and drinks. Be sure to use a tiny amount, as juniper berry essential oil is very concentrated.

It is important to note that juniper berry essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute juniper berry essential oil before using it and avoid eye contact. Juniper berry essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using juniper berry essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Lavender", "Lavender essential oil is a volatile oil extracted from the flowers of the lavender plant. It has a sweet, floral aroma and is often used in aromatherapy, cosmetics, and medicinal products.

Lavender essential oil is rich in linalool and linalyl acetate, compounds with various potential health benefits. These compounds have been shown to have antibacterial, antifungal, anti-inflammatory, and soothing properties.

Lavender essential oil has some potential benefits, including:

• Promoting relaxation and reducing stress: Lavender essential oil's calming and uplifting aroma can help to reduce anxiety and stress. It is also often used to promote sleep.
• Relieving pain and inflammation: Lavender essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Lavender essential oil's antibacterial and antifungal properties can help to treat acne, eczema, and other skin conditions.
• Boosting the immune system: Lavender essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.

Lavender essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse lavender essential oil into the air to enjoy its calming and uplifting aroma. Add a few drops of lavender essential oil to your bath or shower.
• Topical application: Mix a few drops of lavender essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Add a few drops of lavender essential oil to your shampoo, conditioner, or moisturizer.
• Internal use: Lavender essential oil can be taken internally, but this should only be done under the supervision of a qualified healthcare professional.

Lavender essential oil is generally safe for most people to use. However, it is important to note that it can irritate the skin and mucous membranes. It is always important to dilute lavender essential oil before using it and avoid eye contact. Lavender essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using lavender essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Nutmeg", "Nutmeg essential oil is a volatile oil extracted from the dried seeds of the nutmeg tree (Myristica fragrans). It has a warm, spicy, and slightly sweet aroma. Nutmeg essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Nutmeg essential oil is rich in monoterpenes, such as sabinene and alpha-pinene, and esters, such as myristicin and elemicin. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Nutmeg essential oil has many potential health benefits, including:

• Boosting the immune system: Nutmeg essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Nutmeg essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Nutmeg essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Promoting relaxation and sleep: Nutmeg essential oil's warm and spicy aroma can help to promote peace and rest.

Nutmeg essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse nutmeg essential oil into the air to enjoy its warm and spicy aroma. Add a few drops of nutmeg essential oil to your bath or shower.
• Topical application: Mix a few drops of nutmeg essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Be sure to dilute nutmeg essential oil well before applying it to the skin, as it irritates.
• Culinary use: Nutmeg essential oil can flavor food and drinks. Be sure to use a minimal amount, as nutmeg essential oil is very concentrated.

It is important to note that nutmeg essential oil is a concentrated oil and can be irritating to the skin and mucous membranes. It is always important to dilute nutmeg essential oil before using it and avoid eye contact. Nutmeg essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using nutmeg essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Rose Geranium", "Rose geranium essential oil is a steam-distilled oil extracted from the leaves and stems of the Pelargonium genus of plants, which is native to South Africa. It has a sweet, floral aroma with a hint of mint. Rose geranium essential oil is often used in aromatherapy, massage, and skincare products.

Rose geranium essential oil has a number of potential benefits, including:

Antimicrobial and antifungal properties: Rose geranium essential oil has been shown to be effective against a variety of bacteria and fungi, including Staphylococcus aureus, Escherichia coli, and Candida albicans. This makes it a useful oil for cleaning and disinfecting surfaces, as well as for treating skin infections.
Anti-inflammatory and analgesic properties: Rose geranium essential oil has anti-inflammatory and analgesic properties, which can help to relieve pain and inflammation. It can be used to treat muscle pain, headaches, and arthritis.
Anxiolytic and antidepressant properties: Rose geranium essential oil has anxiolytic and antidepressant properties. It can be used to reduce stress, anxiety, and depression. It can also help to promote relaxation and sleep.
Skin care benefits: Rose geranium essential oil is often used in skincare products because it can help to balance the skin's natural oil production, reduce inflammation, and promote healing. It can be used to treat acne, eczema, and psoriasis.
Rose geranium essential oil can be used in a variety of ways, including:

Aromatherapy: Add a few drops of rose geranium essential oil to a diffuser to diffuse the aroma into the air. This can help to create a relaxing and calming atmosphere.
Massage: Add a few drops of rose geranium essential oil to a carrier oil, such as jojoba oil or almond oil, and use it to massage the body. This can help to relieve muscle pain, tension, and stress.
Skin care: Add a few drops of rose geranium essential oil to your favorite moisturizer or cleanser. This can help to balance the skin's natural oil production, reduce inflammation, and promote healing.
It is important to note that essential oils are very potent and should be used with caution. Always dilute essential oils with a carrier oil before applying them to the skin. It is also important to do a patch test before using any new essential oil to make sure you are not allergic.

If you are pregnant or breastfeeding, it is important to consult with your doctor before using rose geranium essential oil.")
        scentMiddle.Add("Red Thyme", "Red thyme essential oil is a volatile oil extracted from the leaves and flowers of the red thyme plant (Thymus vulgaris). It has a warm, spicy, and slightly herbaceous aroma. Red thyme essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Red thyme essential oil is rich in thymol and carvacrol, with antibacterial, antifungal, and anti-inflammatory properties. It is also a good source of other beneficial compounds, such as p-cymene, linalool, and borneol.

Red thyme essential oil has some potential health benefits, including:

• Boosting the immune system: Red thyme essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving respiratory problems: Red thyme essential oil's expectorant and decongestant properties can help to relieve respiratory problems such as bronchitis, asthma, and the common cold.
• Improving digestion: Red thyme essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Reducing pain and inflammation: Red thyme essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.

Red thyme essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse red thyme essential oil into the air to enjoy its warm and spicy aroma. Add a few drops of red thyme essential oil to your bath or shower.
• Topical application: Mix a few drops of red thyme essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute red thyme essential oil well before applying it to the skin, as it irritates.
• Massage: Red thyme essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Red thyme essential oil can flavor food and drinks. Be sure to use a minimal amount, as red thyme essential oil is very concentrated.

It is important to note that red thyme essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute red thyme essential oil before using it and avoid eye contact. Red thyme essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using red thyme essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Marjoram", "Marjoram essential oil is a volatile oil extracted from the leaves and flowers of the marjoram plant (Origanum majorana). It has a warm, herbaceous, and slightly sweet aroma. Marjoram essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Marjoram essential oil is rich in monoterpenes, such as sabinene and alpha-terpinene, and sesquiterpenes, such as caryophyllene. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Marjoram essential oil has many potential health benefits, including:

• Reducing stress and anxiety: Marjoram essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Marjoram essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Marjoram essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Boosting the immune system: Marjoram essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Regulating hormones: Marjoram essential oil is thought to help regulate hormones, which can benefit women's health. It may help to relieve menstrual cramps, premenstrual syndrome (PMS), and menopausal symptoms.

Marjoram essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse marjoram essential oil into the air to enjoy its warm and herbaceous aroma. Add a few drops of marjoram essential oil to your bath or shower.
• Topical application: Mix a few drops of marjoram essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. You can also add a few drops of marjoram essential oil to your shampoo, conditioner, or moisturizer.
• Massage: Marjoram essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Marjoram essential oil can add flavor to food and drinks. Be sure to use a tiny amount, as marjoram essential oil is very concentrated.

It is important to note that marjoram essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute marjoram essential oil before using it and to avoid contact with the eyes. Marjoram essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using marjoram essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Spearmint", "Spearmint essential oil is a volatile oil extracted from the leaves and stems of the spearmint plant (Mentha spicata). It has a fresh, minty aroma with a slightly sweet undertone. Spearmint essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Spearmint essential oil is rich in carvone, a compound with antibacterial, antifungal, and anti-inflammatory properties. It is also a good source of other beneficial compounds, such as limonene, cineole, and menthol.

Spearmint essential oil has some potential health benefits, including:

• Promoting relaxation and reducing stress: Spearmint essential oil has a calming and uplifting aroma that can help to reduce anxiety and stress. It is also often used to promote sleep.
• Improving digestion: Spearmint essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Relieving pain and inflammation: Spearmint essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Boosting the immune system: Spearmint essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Fresh breath: Spearmint essential oil is often used in toothpaste and mouthwash because of its refreshing minty aroma and its ability to freshen breath.

Spearmint essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse spearmint essential oil into the air to enjoy its calming and uplifting aroma. You can also add a few drops of spearmint essential oil to your bath or shower.
• Topical application: Mix a few drops of spearmint essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of spearmint essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Spearmint essential oil can be used to add flavor to food and drinks. Be sure to use a tiny amount, as spearmint essential oil is very concentrated.

It is important to note that spearmint essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute spearmint essential oil before using it and avoid eye contact. Spearmint essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using spearmint essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Oregano", "Oregano essential oil is a volatile oil extracted from the leaves and flowers of the oregano plant (Origanum vulgare). It has a strong, herbaceous aroma with a slightly camphoraceous undertone. Oregano essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Oregano essential oil is rich in monoterpenes, such as carvacrol and thymol, and sesquiterpenes, such as beta-caryophyllene. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Oregano essential oil has several potential health benefits, including:

• Boosting the immune system: Oregano essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving respiratory problems: Oregano essential oil's expectorant and decongestant properties can help to relieve respiratory problems such as bronchitis, asthma, and the common cold.
• Improving digestion: Oregano essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Reducing pain and inflammation: Oregano essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.

Oregano essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse oregano essential oil into the air to enjoy its strong and herbaceous aroma. Add a few drops of oregano essential oil to your bath or shower.
• Topical application: Mix a few drops of oregano essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute oregano essential oil well before applying it to the skin, as it irritates.
• Massage: Oregano essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Oregano essential oil can add flavor to food and drinks. Be sure to use a minimal amount, as oregano essential oil is very concentrated.

It is important to note that oregano essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute oregano essential oil before using it and to avoid contact with the eyes. Oregano essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using oregano essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Palmarosa", "Palmarosa essential oil is a volatile oil extracted from the leaves and flowers of the Cymbopogon martini plant, also known as Indian geranium. It has a sweet, rosy aroma with a slightly citrusy undertone. Palmarosa essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Palmarosa essential oil is rich in geraniol, a compound with antibacterial, antifungal, anti-inflammatory, and analgesic properties. It is also a good source of other beneficial compounds, such as citronellal, linalool, and eugenol.

Palmarosa essential oil has some potential health benefits, including:

• Reducing stress and anxiety: Palmarosa essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Palmarosa essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Palmarosa essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as eczema, psoriasis, and acne.
• Boosting the immune system: Palmarosa essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Repelling insects: Palmarosa essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay.

Palmarosa essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse palmarosa essential oil into the air to enjoy its sweet and rosy aroma. Add a few drops of palmarosa essential oil to your bath or shower.
• Topical application: Mix a few drops of palmarosa essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of palmarosa essential oil to your shampoo, conditioner, or moisturizer.
• Massage: Palmarosa essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Palmarosa essential oil can add flavor to food and drinks. Be sure to use a tiny amount, as palmarosa essential oil is very concentrated.

It is important to note that palmarosa essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute palmarosa essential oil before using it and to avoid contact with the eyes. Palmarosa essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using palmarosa essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Rosemary", "Rosemary essential oil is a volatile oil extracted from the leaves and flowers of the rosemary plant (Rosmarinus officinalis). It has a strong, herbaceous aroma with a slightly camphoraceous undertone. Rosemary essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Rosemary essential oil is rich in monoterpenes, such as camphor and 1,8-cineole, and sesquiterpenes, such as beta-caryophyllene. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Rosemary essential oil has many potential health benefits, including:

• Boosting the immune system: Rosemary essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving respiratory problems: Rosemary essential oil's expectorant and decongestant properties can help to relieve respiratory problems such as bronchitis, asthma, and the common cold.
• Improving digestion: Rosemary essential oil can help to relieve digestive problems such as indigestion, gas, and bloating.
• Reducing pain and inflammation: Rosemary essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving mental alertness and focus: Rosemary essential oil is thought to improve mental attention and focus.
• Promoting hair growth: Rosemary essential oil is thought to promote hair growth by stimulating blood circulation to the scalp.
• Relieving stress and anxiety: Rosemary essential oil's calming and relaxing aroma can help to reduce stress and anxiety.

Rosemary essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse rosemary essential oil into the air to enjoy its strong and herbaceous aroma. You can add a few drops of essential rosemary oil to your bath or shower.
• Topical application: Mix a few drops of rosemary essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Be sure to dilute rosemary essential oil well before applying it to the skin, as it irritates.
• Massage: Rosemary essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Rosemary essential oil can flavor food and drinks. Be sure to use a minimal amount, as rosemary essential oil is very concentrated.

It is important to note that rosemary essential oil is a concentrated oil. It can be irritating to the skin and mucous membranes. It is always important to dilute rosemary essential oil before using it and avoid eye contact. Rosemary essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using rosemary essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Tea Tree", "Tea tree essential oil is a volatile oil extracted from the leaves of the Melaleuca alternifolia tree, native to Australia. It has a fresh, camphoraceous odor and a pale yellow to nearly colorless color. Tea tree essential oil is often used in aromatherapy, cosmetics, and traditional medicine.

Tea tree essential oil is rich in terpenes, such as terpinen-4-ol and gamma-terpinene, which have antibacterial, antifungal, and anti-inflammatory properties. It is also a good source of other beneficial compounds, such as alpha-terpineol and cineole.

Tea tree essential oil has several potential health benefits, including:

• Treating skin conditions: Tea tree essential oil can be used to treat a variety of skin conditions, including acne, eczema, psoriasis, and fungal infections.
• Boosting the immune system: Tea tree essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving respiratory problems: Tea tree essential oil's expectorant and decongestant properties can help to relieve respiratory problems such as bronchitis, asthma, and the common cold.
• Reducing pain and inflammation: Tea tree essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Repelling insects: Tea tree essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay.

Tea tree essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse tea tree essential oil into the air to enjoy its fresh and camphoraceous aroma. Add a few drops of tea tree essential oil to your bath or shower.
• Topical application: Mix a few drops of tea tree essential oil with a carrier oil, such as coconut oil or jojoba oil, and apply it to the skin. Be sure to dilute tea tree essential oil well before applying it to the skin, as it irritates.
• Culinary use: Tea tree essential oil can flavor food and drinks. Be sure to use a tiny amount, as tea tree essential oil is very concentrated.

It is important to note that tea tree essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute tea tree essential oil before using it and avoid eye contact. Tea tree essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using tea tree essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentMiddle.Add("Ylang Ylang", "Ylang-ylang essential oil is a volatile oil extracted from the flowers of the Cananga odorata tree, native to Southeast Asia and the Pacific Islands. It has a sweet, floral aroma with a slightly fruity undertone. Ylang-ylang essential oil is often used in aromatherapy, cosmetics, and traditional medicine.

Ylang-ylang essential oil is rich in monoterpenes, such as linalool and geraniol, and esters, such as linalyl acetate and geranyl acetate. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Ylang-ylang essential oil has some potential health benefits, including:

• Reducing stress and anxiety: Ylang-ylang essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Ylang-ylang essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Ylang-ylang essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as eczema, psoriasis, and acne.
• Boosting the immune system: Ylang-ylang essential oil's antimicrobial properties can help to boost the immune system and protect the body from infection.
• Repelling insects: Ylang-ylang essential oil is a natural insect repellent that can keep mosquitoes and other biting insects at bay.

Ylang-ylang essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse ylang-ylang essential oil into the air to enjoy its sweet and floral aroma. Add a few drops of ylang-ylang essential oil to your bath or shower.
• Topical application: Mix a few drops of ylang-ylang essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute ylang-ylang essential oil well before applying it to the skin, as it can be irritating.
• Massage: Ylang-ylang essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Ylang-ylang essential oil can add flavor to food and drinks. Be sure to use a minimal amount, as ylang-ylang essential oil is very concentrated.

It is important to note that ylang-ylang essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute ylang-ylang essential oil before using it and to avoid contact with the eyes. Ylang-ylang essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using ylang-ylang essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        If scentMiddle.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnScentBase(e As String)
        Dim scentBase As New Dictionary(Of String, String)
        scentBase.Add("Ylang Ylang", "Ylang-ylang essential oil is a volatile oil extracted from the flowers of the Cananga odorata tree, native to Southeast Asia and the Pacific Islands. It has a sweet, floral aroma with a slightly fruity undertone. Ylang-ylang essential oil is often used in aromatherapy, cosmetics, and traditional medicine.

Ylang-ylang essential oil is rich in monoterpenes, such as linalool and geraniol, and esters, such as linalyl acetate and geranyl acetate. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Ylang-ylang essential oil has several potential health benefits, including:

• Reducing stress and anxiety: Ylang-ylang essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Ylang-ylang essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Ylang-ylang essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as eczema, psoriasis, and acne.
• Boosting the immune system: Ylang-ylang essential oil's antimicrobial properties can help to boost the immune system and protect the body from infection.
• Repelling insects: Ylang-ylang essential oil is a natural insect repellent that can keep mosquitoes and other biting insects at bay.

Ylang-ylang essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse ylang-ylang essential oil into the air to enjoy its sweet and floral aroma. Add a few drops of ylang-ylang essential oil to your bath or shower.
• Topical application: Mix a few drops of ylang-ylang essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute ylang-ylang essential oil well before applying it to the skin, as it irritates.
• Massage: Ylang-ylang essential oil can relieve muscle tension and promote relaxation.
• Culinary use: Ylang-ylang essential oil can add flavor to food and drinks. Be sure to use a minimal amount, as ylang-ylang essential oil is very concentrated.

It is important to note that ylang-ylang essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute ylang-ylang essential oil before using it and to avoid contact with the eyes. Ylang-ylang essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using ylang-ylang essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Black Pepper", "Black pepper essential oil is a volatile oil extracted from the dried and crushed peppercorns of the Piper nigrum plant. It has a warm, spicy, and woody aroma. Black pepper essential oil is often used in aromatherapy, cosmetics, and culinary applications.

Black pepper essential oil is rich in monoterpenes, such as alpha-pinene and beta-pinene, and sesquiterpenes, such as caryophyllene. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Black pepper essential oil has several potential health benefits, including:

• Boosting the immune system: Black pepper essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Relieving pain and inflammation: Black pepper essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving digestion: Black pepper essential oil can help to relieve digestive problems such as indigestion, gas, and bloating. It can also help to stimulate the appetite.
• Repelling insects: Black pepper essential oil is a natural insect repellent that can keep mosquitoes, ticks, and other biting insects at bay.

Black pepper essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse black pepper essential oil into the air to enjoy its warm and spicy aroma. Add a few drops of black pepper essential oil to your bath or shower.
• Topical application: Mix a few drops of black pepper essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Add a few drops of black pepper essential oil to your shampoo, conditioner, or moisturizer.
• Culinary use: Black pepper essential oil can flavor food and drinks. Be sure to use a tiny amount, as black pepper essential oil is very concentrated.

It is important to note that black pepper essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute black pepper essential oil before using it and avoid eye contact. Black pepper essential oil is also not recommended for pregnant or breastfeeding women or children under the age of 6.

If you are considering using black pepper essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Cedarwood Atlas", "Cedarwood Atlas essential oil is a volatile oil extracted from the wood of the Cedrus atlantica tree, native to the Atlas Mountains of Morocco. It has a warm, woody aroma with a slightly sweet undertone. Cedarwood Atlas essential oil is often used in aromatherapy, cosmetics, and perfumery.

Cedarwood Atlas essential oil is rich in sesquiterpenes, such as cedrol and cedrene, which have antibacterial, antifungal, anti-inflammatory, and analgesic properties. It is also a good source of other beneficial compounds, such as alpha-cedrene and beta-thujone.

Cedarwood Atlas essential oil has several potential health benefits, including:

• Relieving stress and anxiety: Cedarwood Atlas essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Cedarwood Atlas essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Cedarwood Atlas essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as acne, eczema, and psoriasis.
• Boosting the immune system: Cedarwood Atlas essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Repelling insects: Cedarwood Atlas essential oil is a natural insect repellent that can keep mosquitoes and other biting insects at bay.

Cedarwood Atlas essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse Cedarwood Atlas essential oil into the air to enjoy its warm and woody aroma. Add a few drops of Cedarwood Atlas essential oil to your bath or shower.
• Topical application: Mix a few drops of Cedarwood Atlas essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute Cedarwood Atlas essential oil well before applying it to the skin, as it irritates.
• Massage: Cedarwood Atlas essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Cedarwood Atlas essential oil can add flavor to food and drinks. Be sure to use a minimal amount, as Cedarwood Atlas essential oil is very concentrated.

It is important to note that Cedarwood Atlas essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute Cedarwood Atlas essential oil before using it and to avoid contact with the eyes. Cedarwood Atlas essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using Cedarwood Atlas essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Frankincense", "Frankincense essential oil is a volatile oil extracted from the resin of the Boswellia tree, which is native to northeastern Africa, the Arabian Peninsula, and India. It has a warm, woody aroma with a slightly citrusy undertone. Frankincense essential oil is often used in aromatherapy, cosmetics, and traditional medicine.

Frankincense essential oil is rich in monoterpenes, such as alpha-pinene and limonene, and sesquiterpenes, such as boswellic acid. These compounds have a variety of potential health benefits, including antibacterial, antifungal, anti-inflammatory, and analgesic properties.

Frankincense essential oil has some potential health benefits, including:

• Reducing stress and anxiety: Frankincense essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Frankincense essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Frankincense essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as acne, eczema, and psoriasis.
• Boosting the immune system: Frankincense essential oil's antimicrobial properties can help to boost the immune system and protect the body from infection.
• Supporting respiratory health: Frankincense essential oil is thought to help support respiratory health by relieving congestion and inflammation.

Frankincense essential oil can be used in a variety of ways, including:

Aromatherapy: Diffuse frankincense essential oil into the air to enjoy its warm and woody aroma. Add a few drops of frankincense essential oil to your bath or shower.

• Topical application: Mix a few drops of frankincense essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute frankincense essential oil well before applying it to the skin, as it irritates.
• Massage: Frankincense essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Frankincense essential oil can add flavor to food and drinks. Be sure to use a tiny amount, as frankincense essential oil is very concentrated.

It is important to note that frankincense essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute frankincense essential oil before using it and to avoid contact with the eyes. Frankincense essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using frankincense essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Patchouli", "Patchouli essential oil is a volatile oil extracted from the leaves of the Pogostemon cablin plant, which is native to Southeast Asia. It has a deep, earthy aroma with a slightly sweet undertone. Patchouli essential oil is often used in aromatherapy, cosmetics, and perfumery.

Patchouli essential oil is rich in sesquiterpenes, such as patchoulol and norpatchoulenol, which have antibacterial, antifungal, anti-inflammatory, and analgesic properties. It is also a good source of other beneficial compounds, such as guaiol and alpha-humulene.

Patchouli essential oil has many potential health benefits, including:

Reducing stress and anxiety: Patchouli essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.

• Relieving pain and inflammation: Patchouli essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Patchouli essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as acne, eczema, and psoriasis.
• Boosting the immune system: Patchouli essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Repelling insects: Patchouli essential oil is a natural insect repellent that can keep mosquitoes and other biting insects at bay.

Patchouli essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse patchouli essential oil into the air to enjoy its profound and earthy aroma. Add a few drops of patchouli essential oil to your bath or shower.
• Topical application: Mix a few drops of patchouli essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Be sure to dilute patchouli essential oil well before applying it to the skin, as it irritates.
• Massage: Patchouli essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Patchouli essential oil can add flavor to food and drinks. Be sure to use a minimal amount, as patchouli essential oil is very concentrated.

It is important to note that patchouli essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute patchouli essential oil before using it and avoid eye contact. Patchouli essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using patchouli essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Sandalwood", "Sandalwood essential oil is a volatile oil extracted from the wood and roots of the Santalum album tree, also known as the East Indian sandalwood tree. It is one of the world's most expensive essential oils due to the sandalwood tree's slow growth and the high demand for its oil.

Sandalwood essential oil has a warm, woody aroma with a slightly sweet undertone. It is often used in aromatherapy, cosmetics, and perfumery. Sandalwood essential oil is also used in traditional medicine to treat various conditions, including anxiety, depression, insomnia, and skin problems.

Sandalwood essential oil is rich in sesquiterpenes, such as alpha-santalol and beta-santalol, which have antibacterial, antifungal, anti-inflammatory, and analgesic properties. It is also a good source of other beneficial compounds, such as alpha-cedrene and beta-thujone.

Sandalwood essential oil has several potential health benefits, including:

• Reducing stress and anxiety: Sandalwood essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Sandalwood essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Sandalwood essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as acne, eczema, and psoriasis.
• Boosting the immune system: Sandalwood essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.

Sandalwood essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse sandalwood essential oil into the air to enjoy its warm and woody aroma. Add a few drops of sandalwood essential oil to your bath or shower.
• Topical application: Mix a few drops of sandalwood essential oil with carrier oil, such as coconut or jojoba oil, and apply them to the skin. Be sure to dilute sandalwood essential oil well before applying it to the skin, as it irritates.
• Massage: Sandalwood essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Sandalwood essential oil can add flavor to food and drinks. Be sure to use a tiny amount, as sandalwood essential oil is very concentrated.

It is important to note that sandalwood essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute sandalwood essential oil before using it and avoid eye contact. Sandalwood essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using sandalwood essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Vetiver", "Vetiver essential oil is a volatile oil extracted from the roots of the Vetiveria zizanioides plant, known as khus grass. It is a native plant of India and is widely cultivated in other tropical and subtropical regions. Vetiver essential oil has a deep, earthy aroma and slightly woody undertone. It is often used in aromatherapy, cosmetics, and perfumery.

Vetiver essential oil is rich in sesquiterpenes, such as vetiverone and vetivenol, which have antibacterial, antifungal, anti-inflammatory, and analgesic properties. It is also a good source of other beneficial compounds, such as beta-caryophyllene and khusimol.

Vetiver essential oil has several potential health benefits, including:

• Reducing stress and anxiety: Vetiver essential oil's calming and relaxing aroma can help to reduce stress and anxiety. It can also help to promote sleep.
• Relieving pain and inflammation: Vetiver essential oil's anti-inflammatory and analgesic properties can help relieve pain and inflammation caused by arthritis, muscle aches, and headaches.
• Improving skin health: Vetiver essential oil's antibacterial and anti-inflammatory properties can help to treat skin conditions such as acne, eczema, and psoriasis.
• Boosting the immune system: Vetiver essential oil's antimicrobial properties can help boost the immune system and protect the body from infection.
• Repelling insects: Vetiver essential oil is a natural insect repellent that can keep mosquitoes and other biting insects at bay.

Vetiver essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse vetiver essential oil into the air to enjoy its profound and earthy aroma. Add a few drops of vetiver essential oil to your bath or shower.
• Topical application: Mix a few drops of vetiver essential oil with carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute vetiver essential oil well before applying it to the skin, as it irritates.
• Massage: Vetiver essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Vetiver essential oil can flavor food and drinks. Be sure to use a minimal amount, as vetiver essential oil is very concentrated.

It is important to note that vetiver essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute vetiver essential oil before using it and avoid eye contact. Vetiver essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using vetiver essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Peppermint", "Peppermint essential oil is a volatile oil extracted from the leaves of the peppermint plant (Mentha x piperita). It is a hybrid mint that is a cross between spearmint and watermint. Peppermint essential oil is one of the most popular essential oils in the world due to its refreshing aroma and wide range of potential health benefits.

Peppermint essential oil is rich in menthol and menthone, which give peppermint its characteristic aroma and flavor. Menthol and menthone also have some potential health benefits, including:

• Pain relief: Menthol and menthone have analgesic and anti-inflammatory properties, making them practical for relieving pain caused by arthritis, headaches, and muscle aches.
• Digestive support: Peppermint essential oil can help improve digestion by relaxing the digestive tract muscles and relieving symptoms such as gas, bloating, and indigestion.
• Respiratory support: Menthol and menthone can help to clear the sinuses and relieve congestion, making peppermint essential oil a valuable remedy for the common cold and other respiratory infections.
• Mood enhancement: Peppermint essential oil has a stimulating and invigorating aroma that can help to improve mood and energy levels.

Peppermint essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse peppermint essential oil into the air to enjoy its refreshing aroma and reap its therapeutic benefits. Add a few drops of peppermint essential oil to your bath or shower.
• Topical application: Mix a few drops of peppermint essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute peppermint essential oil well before applying it to the skin, as it irritates.
• Massage: Peppermint essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Peppermint essential oil can flavor food and drinks. Be sure to use a tiny amount, as peppermint essential oil is very concentrated.

It is important to note that peppermint essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute peppermint essential oil before using it and avoid eye contact. Peppermint essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using peppermint essential oil, it is important to talk to your doctor first to make sure it is safe for you.")
        scentBase.Add("Myrrh", "Myrrh essential oil is a volatile oil extracted from the gum resin of the Commiphora myrrha tree, which is native to the Middle East and East Africa. It has a warm, balsamic, slightly spicy aroma. Myrrh essential oil has been used for centuries in traditional medicine and religious ceremonies.

Myrrh essential oil is rich in sesquiterpenes, such as furanodiene, curzerene, and limonene, which have antibacterial, antifungal, anti-inflammatory, and analgesic properties. It is also a good source of other beneficial compounds, such as eugenol and guaiol.

Myrrh essential oil has many potential health benefits, including:

• Boosting the immune system
• Reducing inflammation
• Relieving pain
• Healing wounds
• Improving skin health
• Reducing stress and anxiety

Myrrh essential oil can be used in a variety of ways, including:

• Aromatherapy: Diffuse myrrh essential oil into the air or add a few drops to your bath or shower to enjoy its warm, balsamic aroma.
• Topical application: Mix a few drops of myrrh essential oil with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute myrrh essential oil well before applying it to the skin, as it irritates.
• Massage: Myrrh essential oil can be used in massage to relieve muscle tension and promote relaxation.
• Culinary use: Myrrh essential oil can flavor food and drinks. Be sure to use a minimal amount, as myrrh essential oil is very concentrated.

It is important to note that myrrh essential oil is a concentrated oil that can irritate the skin and mucous membranes. It is always important to dilute myrrh essential oil before using it and to avoid contact with the eyes. Myrrh essential oil is also not recommended for pregnant or breastfeeding women or children under 6.

If you are considering using myrrh essential oil, it is important to talk to your doctor first to ensure it is safe.
")
        scentBase.Add("Vanilla", "Strictly speaking, there is no such thing as a vanilla essential oil. Essential oils are extracted from plants using steam distillation or cold pressing. However, vanilla beans are too delicate to withstand the heat of steam distillation, and cold pressing produces no oil.

Instead, vanilla oleoresin is extracted from vanilla beans using a solvent. Vanilla oleoresin is a thick, concentrated liquid with the same sweet, warm aroma as vanilla beans. It is commonly used in perfumery, cosmetics, and food flavoring.

Vanilla oleoresin is sometimes marketed as vanilla essential oil. Still, it is important to note that it is not a true essential oil. It is also more expensive than most essential oils, and it should be used cautiously, as it can irritate the skin.

Even though vanilla oleoresin is not a true essential oil, it still has many of the same benefits as essential oils. It is known for its calming and relaxing properties, and it can also be used to boost mood and improve cognitive function.

Vanilla oleoresin can be used in a variety of ways. It can be added to a diffuser to create a calming and relaxing atmosphere. It can also be added to lotions, creams, and other skincare products to soothe and moisturize the skin. Vanilla oleoresin can also be added to food and drinks for flavor.

Here are some of the potential benefits of vanilla oleoresin:

• Mood booster
• Relaxing and calming
• Antibacterial and antifungal
• Antioxidant
• Anti-inflammatory
• Pain reliever
• Digestive aid
• Aphrodisiac

When using vanilla oleoresin, it is essential to dilute it with a carrier oil, such as jojoba oil or almond oil. This will help to prevent skin irritation. Vanilla oleoresin should also be avoided during pregnancy and lactation.
")
        If scentBase.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnScentBlendsWellWith(e As String)
        Dim scentBlendsWell As New Dictionary(Of String, String)
        scentBlendsWell.Add("Citrus", "Blends well with Floral, Woody, Herbal & Spicy")
        scentBlendsWell.Add("Floral", "Blends well with Citrus, Spicy & Woody")
        scentBlendsWell.Add("Herbal", "Blends well with Woody & Spicy")
        scentBlendsWell.Add("Spicy", "Blends well with Floral, Woody & Citrus")
        scentBlendsWell.Add("Woody", "Blends well with Floral, Citrus, Herbal & Spicy")
        Return scentBlendsWell(e)
    End Function
    Public Function fnFragrance(e As String)
        Dim scentFragrance As New Dictionary(Of String, String)
        scentFragrance.Add("Citrus", "Bergamot, Citronella, Grapefruit, Lemon, Lemongrass, Lime, Neroli, Sweet Orange, Petitgrain")
        scentFragrance.Add("Floral", "Rose Geranium, Geranium, Lavender, Palmarosa, Ylang Ylang")
        scentFragrance.Add("Herbal", "Basil, Chamomile, Clary Sage, Eucalyptus, Marjoram, Spearmint, Oregano, Rosemary, Sage, Tea Tree, Red Thyme")
        scentFragrance.Add("Spicy", "Coriander, Black Pepper, Cinnamon Leaf, Clove, Nutmeg, Peppermint,Myrrh")
        scentFragrance.Add("Woody", "Cedarwood Atlas, Cypress, Frankincense, Juniper Berry, Patchouli, Petitgrain, Pine Needle, Sandalwood, Vetiver")
        Return scentFragrance(e)
    End Function
    Public Function fnFragranceCitrus(e As String)
        Dim FragranceCitrus As New Dictionary(Of String, String)
        FragranceCitrus.Add("Bergamot", "Citrus")
        FragranceCitrus.Add("Citronella", "Citrus")
        FragranceCitrus.Add("Grapefruit", "Citrus")
        FragranceCitrus.Add("Lemon", "Citrus")
        FragranceCitrus.Add("Lemongrass", "Citrus")
        FragranceCitrus.Add("Lime", "Citrus")
        FragranceCitrus.Add("Neroli", "Citrus")
        FragranceCitrus.Add("Sweet Orange", "Citrus")
        FragranceCitrus.Add("Petitgrain", "Citrus")
        If FragranceCitrus.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnFragranceFloral(e As String)
        Dim FragranceFloral As New Dictionary(Of String, String)
        FragranceFloral.Add("Rose Geranium", "Floral")
        FragranceFloral.Add("Geranium", "Floral")
        FragranceFloral.Add("Lavender", "Floral")
        FragranceFloral.Add("Palmarosa", "Floral")
        FragranceFloral.Add("Ylang Ylang", "Floral")
        If FragranceFloral.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnFragranceHerbal(e As String)
        Dim FragranceHerbal As New Dictionary(Of String, String)
        FragranceHerbal.Add("Basil", "Herbal")
        FragranceHerbal.Add("Chamomile", "Herbal")
        FragranceHerbal.Add("Clary Sage", "Herbal")
        FragranceHerbal.Add("Eucalyptus", "Herbal")
        FragranceHerbal.Add("Marjoram", "Herbal")
        FragranceHerbal.Add("Spearmint", "Herbal")
        FragranceHerbal.Add("Oregano", "Herbal")
        FragranceHerbal.Add("Rosemary", "Herbal")
        FragranceHerbal.Add("Sage", "Herbal")
        FragranceHerbal.Add("Tea Tree", "Herbal")
        FragranceHerbal.Add("Red Thyme", "Herbal")
        If FragranceHerbal.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnFragranceSpicy(e As String)
        Dim FragranceSpicy As New Dictionary(Of String, String)
        FragranceSpicy.Add("Coriander", "Spicy")
        FragranceSpicy.Add("Black Pepper", "Spicy")
        FragranceSpicy.Add("Cinnamon Leaf", "Spicy")
        FragranceSpicy.Add("Clove", "Spicy")
        FragranceSpicy.Add("Nutmeg", "Spicy")
        FragranceSpicy.Add("Peppermint", "Spicy")
        FragranceSpicy.Add("Myrrh", "Spicy")
        If FragranceSpicy.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnFragranceWoody(e As String)
        Dim FragranceWoody As New Dictionary(Of String, String)
        FragranceWoody.Add("Cedarwood Atlas", "Woody")
        FragranceWoody.Add("Cypress", "Woody")
        FragranceWoody.Add("Frankincense", "Woody")
        FragranceWoody.Add("Juniper Berry", "Woody")
        FragranceWoody.Add("Patchouli", "Woody")
        FragranceWoody.Add("Petitgrain", "Woody")
        FragranceWoody.Add("Pine Needle", "Woody")
        FragranceWoody.Add("Sandalwood", "Woody")
        FragranceWoody.Add("Vetiver", "Woody")
        If FragranceWoody.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnScentMode(e As String)
        Dim scentMode As New Dictionary(Of String, String)
        scentMode.Add("Energizing", "Bergamot, Citronella, Grapefruit, Lemon, Lemongrass, Lime, Sweet Orange, Coriander, Black Pepper, Cinnamon Leaf, Clove, Cypress, Petitgrain, Pine Needle, Basil, Clary Sage, Eucalyptus, Spearmint, Peppermint, Rosemary, Sage, Tea Tree")
        scentMode.Add("Relaxing", "Bergamot, Rose Geranium, Geranium, Lavender, Palmarosa, Ylang Ylang, Nutmeg, Cedarwood Atlas, Frankincense, Patchouli, Vetiver, Clary Sage, Sage, Red Thyme,Myrrh")
        scentMode.Add("Cleansing", "Citronella, Grapefruit, Lemon, Lime, Sweet Orange, Nutmeg, Oregano, Juniper Berry, Patchouli, Peppermint")
        scentMode.Add("Grounding", "Bergamot, Sweet Orange, Rose Geranium, Geranium, Lavender, Coriander, Black Pepper, Clove, Oregano, Cedarwood Atlas, Frankincense, Sandalwood, Vetiver, Chamomile, Marjoram, Spearmint, Red Thyme")
        Return scentMode(e)
    End Function
    Public Function fnScentModeEnergizing(e As String)
        Dim scentModeEnergizing As New Dictionary(Of String, String)
        scentModeEnergizing.Add("Bergamot", "Energizing")
        scentModeEnergizing.Add("Citronella", "Energizing")
        scentModeEnergizing.Add("Grapefruit", "Energizing")
        scentModeEnergizing.Add("Lemon", "Energizing")
        scentModeEnergizing.Add("Lemongrass", "Energizing")
        scentModeEnergizing.Add("Lime", "Energizing")
        scentModeEnergizing.Add("Sweet Orange", "Energizing")
        scentModeEnergizing.Add("Coriander", "Energizing")
        scentModeEnergizing.Add("Black Pepper", "Energizing")
        scentModeEnergizing.Add("Cinnamon Leaf", "Energizing")
        scentModeEnergizing.Add("Clove", "Energizing")
        scentModeEnergizing.Add("Cypress", "Energizing")
        scentModeEnergizing.Add("Petitgrain", "Energizing")
        scentModeEnergizing.Add("Pine Needle", "Energizing")
        scentModeEnergizing.Add("Basil", "Energizing")
        scentModeEnergizing.Add("Clary Sage", "Energizing")
        scentModeEnergizing.Add("Eucalyptus", "Energizing")
        scentModeEnergizing.Add("Spearmint", "Energizing")
        scentModeEnergizing.Add("Peppermint", "Energizing")
        scentModeEnergizing.Add("Rosemary", "Energizing")
        scentModeEnergizing.Add("Sage", "Energizing")
        scentModeEnergizing.Add("Tea Tree", "Energizing")
        If scentModeEnergizing.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnScentModeRelaxing(e As String)
        Dim scentModeRelaxing As New Dictionary(Of String, String)
        scentModeRelaxing.Add("Bergamot", "Relaxing")
        scentModeRelaxing.Add("Rose Geranium", "Relaxing")
        scentModeRelaxing.Add("Geranium", "Relaxing")
        scentModeRelaxing.Add("Lavender", "Relaxing")
        scentModeRelaxing.Add("Palmarosa", "Relaxing")
        scentModeRelaxing.Add("Ylang Ylang", "Relaxing")
        scentModeRelaxing.Add("Nutmeg", "Relaxing")
        scentModeRelaxing.Add("Cedarwood Atlas", "Relaxing")
        scentModeRelaxing.Add("Frankincense", "Relaxing")
        scentModeRelaxing.Add("Patchouli", "Relaxing")
        scentModeRelaxing.Add("Vetiver", "Relaxing")
        scentModeRelaxing.Add("Clary Sage", "Relaxing")
        scentModeRelaxing.Add("Sage", "Relaxing")
        scentModeRelaxing.Add("Red Thyme", "Relaxing")
        scentModeRelaxing.Add("Myrrh", "Relaxing")
        If scentModeRelaxing.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnScentModeCleansing(e As String)
        Dim scentModeCleansing As New Dictionary(Of String, String)
        scentModeCleansing.Add("Citronella", "Cleansing")
        scentModeCleansing.Add("Grapefruit", "Cleansing")
        scentModeCleansing.Add("Lemon", "Cleansing")
        scentModeCleansing.Add("Lime", "Cleansing")
        scentModeCleansing.Add("Sweet Orange", "Cleansing")
        scentModeCleansing.Add("Nutmeg", "Cleansing")
        scentModeCleansing.Add("Oregano", "Cleansing")
        scentModeCleansing.Add("Juniper Berry", "Cleansing")
        scentModeCleansing.Add("Patchouli", "Cleansing")
        scentModeCleansing.Add("Peppermint", "Cleansing")
        If scentModeCleansing.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function
    Public Function fnScentModeGrounding(e As String)
        Dim scentModeGrounding As New Dictionary(Of String, String)
        scentModeGrounding.Add("Bergamot", "Grounding")
        scentModeGrounding.Add("Sweet Orange", "Grounding")
        scentModeGrounding.Add("Rose Geranium", "Grounding")
        scentModeGrounding.Add("Geranium", "Grounding")
        scentModeGrounding.Add("Lavender", "Grounding")
        scentModeGrounding.Add("Coriander", "Grounding")
        scentModeGrounding.Add("Black Pepper", "Grounding")
        scentModeGrounding.Add("Clove", "Grounding")
        scentModeGrounding.Add("Oregano", "Grounding")
        scentModeGrounding.Add("Cedarwood Atlas", "Grounding")
        scentModeGrounding.Add("Frankincense", "Grounding")
        scentModeGrounding.Add("Sandalwood", "Grounding")
        scentModeGrounding.Add("Vetiver", "Grounding")
        scentModeGrounding.Add("Chamomile", "Grounding")
        scentModeGrounding.Add("Marjoram", "Grounding")
        scentModeGrounding.Add("Spearmint", "Grounding")
        scentModeGrounding.Add("Red Thyme", "Grounding")
        If scentModeGrounding.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function

    Public Function fnScentNotes(e As String)
        Dim scentNotes As New Dictionary(Of String, String)
        scentNotes.Add("Top", "Top note essential oils are the first to evaporate when diffused or applied to the skin. They have a light, airy aroma often described as refreshing and uplifting. Top note essential oils are often used in blends to create a sense of balance and harmony.

Here is a list of some popular top note essential oils:

Basil
Bergamot
Eucalyptus
Grapefruit
Lemon
Lemongrass
Lime
Mandarin
Neroli
Orange
Peppermint
Spearmint
Tangerine
Top note essential oils can be used in a variety of ways, including:

Aromatherapy: Diffuse top note essential oils into the air to enjoy their refreshing and uplifting aromas. Add a few drops of top note essential oils to your bath or shower.
Topical application: Mix a few drops of top note essential oils with a carrier oil, such as coconut oil or jojoba oil, and apply it to the skin. Be sure to dilute top note essential oils well before applying them to the skin, as they irritate.
Massage: Top note essential oils can be used in massage to relieve muscle tension and promote relaxation.
Culinary use: Top note essential oils can add flavor to food and drinks. Be sure to use a tiny amount, as top note essential oils are very concentrated.
It is important to note that top note essential oils are volatile and can evaporate quickly. If you use top note essential oils in a diffuser, you may need to add more oil more frequently than you would with middle or base note essential oils.

If you are considering using top note essential oils, it is important to talk to your doctor first to make sure they are safe for you.")
        scentNotes.Add("Middle", "Middle note essential oils are the heart of the essential oil blend. They have a more complex and balanced aroma than top note essential oils, and they evaporate more slowly. Middle note essential oils are often used to create a sense of harmony and balance in a blend.

Here is a list of some popular middle note essential oils:

Chamomile
Cinnamon
Clary sage
Clove
Cypress
Fennel
Geranium
Ginger
Jasmine
Lavender
Marjoram
Melissa
Nutmeg
Palmarosa
Patchouli
Petitgrain
Rose
Rosemary
Sandalwood
Thyme
Vetiver
Ylang-ylang
Middle note essential oils can be used in a variety of ways, including:

Aromatherapy: Diffuse middle note essential oils into the air to enjoy their complex and balanced aromas. Add a few drops of middle note essential oils to your bath or shower.
Topical application: Mix a few drops of middle note essential oils with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute middle note essential oils well before applying them to the skin, as they irritate.
Massage: Middle note essential oils can be used in massage to relieve muscle tension and promote relaxation.
Culinary use: Middle note essential oils can be used to add flavor to food and drinks. Be sure to use a tiny amount, as middle note essential oils are very concentrated.
It is important to note that middle note essential oils can vary in their evaporation rate. Some middle note essential oils, such as chamomile and lavender, evaporate more slowly than others, such as cinnamon and ginger. When blending middle note essential oils, it is vital to consider their evaporation rates to create a blend that will last.

Suppose you are considering using middle note essential oils. In that case, it is important to talk to your doctor first to ensure they are safe.

Please note that this is not an exhaustive list of middle note essential oils. There are many other wonderful middle note essential oils available.")
        scentNotes.Add("Bottom", "Base note essential oils are the last to evaporate when diffused or applied to the skin. They have a deep, rich aroma often described as grounding and centering. Base note essential oils are often used in blends to create a sense of balance and harmony.

Here is a list of some popular base note essential oils:

Benzoin
Cedarwood
Frankincense
Myrrh
Patchouli
Sandalwood
Vetiver
Base note essential oils can be used in a variety of ways, including:

Aromatherapy: Diffuse base note essential oils into the air to enjoy their deep, rich aromas. Add a few drops of base note essential oils to your bath or shower.
Topical application: Mix a few drops of base note essential oils with a carrier oil, such as coconut or jojoba oil, and apply it to the skin. Be sure to dilute base note essential oils well before applying them to the skin, as they can be irritating.
Massage: Base note essential oils can be used in massage to relieve muscle tension and promote relaxation.
Culinary use: Base note essential oils can flavor food and drinks. Be sure to use a minimal amount, as base note essential oils are very concentrated.
It is important to note that base note essential oils evaporate slowly. If you use base note essential oils in a diffuser, you may not need to add more oil as often as you would with top note or middle note essential oils.

If you are considering using base note essential oils, it is important to talk to your doctor first to ensure they are safe.

Please note that this is not an exhaustive base note essential oils list. There are many other wonderful base note essential oils available.")
        Return scentNotes(e)
    End Function
    Public Function fnCarrierOils(e As String)
        Dim CarrierOils As New Dictionary(Of String, String)
        CarrierOils.Add("Coconut", "Coconut oil is a popular carrier oil for essential oils because it is inexpensive, readily available, and has several beneficial properties. It is a solid oil at room temperature but melts when warmed. Coconut oil is also non-comedogenic, meaning that it is not likely to clog pores.

Coconut oil is a good carrier oil for essential oils because it:

• Is easily absorbed by the skin: This allows the essential oils to be delivered more deeply into the skin, where they can provide their therapeutic benefits.
• Is moisturizing: Coconut oil is a good source of fatty acids, which help to hydrate and moisturize the skin.
• Has antibacterial and antifungal properties: This can help to protect the skin from infection.
• Is relatively inexpensive and readily available: Coconut oil is a popular cooking oil, so it is easy to find in grocery stores and is relatively affordable.

However, it is essential to note that coconut oil can irritate some people's skin. It is also vital to be aware that coconut oil can solidify at room temperature, so you may need to warm it up before using it as a carrier oil.

Mix a few drops of essential oil with a teaspoon of coconut oil to use coconut oil as a carrier. You can then apply the blend to your skin or diffuse it into the air.

Here are some tips for using coconut oil as a carrier oil:

• Start with a low dilution: If you are new to essential oils, it is crucial to start with a low dilution and gradually increase the concentration as you become more comfortable.
• Do a patch test: Before using any new essential oil or carrier oil on your skin, do a patch test. To do a patch test, apply a small amount of the oil to the inside of your forearm and wait 24 hours. If you experience any irritation, do not use the oil.
• Warm the coconut oil before using: If it is solidified, warm it up by placing the bottle in a warm water bath.
• Apply the blend to your skin: You can apply the blend of coconut and essential oil to any skin area. Be sure to avoid the eyes and other sensitive areas.
• Diffuse the blend into the air: Using a diffuser, you can also diffuse the blend of coconut oil and essential oil into the air. This is a great way to enjoy the benefits of essential oils without applying them to your skin.

If you are considering using coconut oil as a carrier oil, be sure to talk to your doctor first to make sure it is safe for you.")
        CarrierOils.Add("Grapeseed", "Grapeseed oil is a popular carrier oil for essential oils because it is lightweight, non-comedogenic, and has a neutral scent. It absorbs quickly into the skin and does not leave a greasy residue. Grapeseed oil is also rich in vitamin E and other antioxidants, which can help to nourish and protect the skin.

To use grapeseed oil as a carrier, mix a few drops of essential oil with 1 teaspoon of grapeseed oil. You can then apply the blend to your skin or diffuse it into the air.

Here are some of the benefits of using grapeseed oil as a carrier oil:

• Lightweight and non-comedogenic: Grapeseed oil is a lightweight oil that absorbs quickly into the skin without leaving a greasy residue. It is also non-comedogenic, meaning that it does not clog pores. This makes it a good choice for people with oily or acne-prone skin.
• Neutral scent: Grapeseed oil has a neutral smell, so it will not interfere with the aroma of your essential oils.
• Rich in vitamin E and antioxidants: Grapeseed oil is rich in vitamin E and other antioxidants, which can help to nourish and protect the skin. Vitamin E is a natural moisturizer that can help to hydrate and soften the skin. Antioxidants can help to protect the skin from damage caused by free radicals.

Grapeseed oil can be used to dilute a wide variety of essential oils. It is famous for essential oils such as lavender, chamomile, peppermint, and tea tree. Grapeseed oil can also dilute essential oils for massage, aromatherapy, and other topical applications.

Here are some tips for using grapeseed oil as a carrier oil:

• Start with a low dilution and gradually increase the concentration as you become more comfortable.
• Do a patch test before using any new essential or carrier oil on your skin.
• Store grapeseed oil in a cool, dark place. It has a shelf life of approximately 12 months.

Suppose you want a lightweight, non-comedogenic carrier oil with a neutral scent. In that case, grapeseed oil is a great option. It is a versatile oil that can be used to dilute a wide variety of essential oils for a variety of applications.")
        CarrierOils.Add("Jojoba", "Jojoba oil is a popular carrier oil for essential oils because it is closely similar to human sebum, the skin's natural oil. This makes it easily absorbed by the skin and less likely to clog pores. Jojoba oil is also non-comedogenic, which is unlikely to cause breakouts.

Jojoba oil is also a good choice for carrier oils because it is odorless and has a long shelf life. This means that it will not interfere with the aroma of the essential oils you use and will not spoil quickly.

To use jojoba oil as a carrier for essential oils, mix a few drops of essential oil with a teaspoon of jojoba oil. You can then apply the blend to your skin or diffuse it into the air.

Here are some of the benefits of using jojoba oil as a carrier oil for essential oils:

• It is easily absorbed by the skin.
• It is less likely to clog pores.
• It is non-comedogenic.
• It is odorless.
• It has a long shelf life.

Jojoba oil can dilute various essential oils, including lavender, peppermint, tea tree oil, and frankincense. It is a versatile and practical carrier oil that can be used for multiple purposes.

If you are considering using jojoba oil as a carrier oil for essential oils, be sure to talk to your doctor first to make sure it is safe for you.")
        CarrierOils.Add("Sweet almond", "Sweet almond oil is a popular carrier oil used in aromatherapy and essential oil blending. It is a light, non-greasy oil easily absorbed into the skin. Sweet almond oil is also rich in vitamins and fatty acids, which can help to nourish and protect the skin.

Sweet almond oil is a good carrier oil for essential oils because it is less likely to irritate the skin than other carrier oils, such as coconut or olive oil. It is also odorless, so it will not interfere with the aroma of the essential oils.

To use sweet almond oil as a carrier, mix a few drops of essential oil with 1 teaspoon of sweet almond oil. You can then apply the blend to your skin or diffuse it into the air.

Here are some of the benefits of using sweet almond oil as a carrier oil:

• It is light and non-greasy, easily absorbed into the skin without leaving a greasy residue.
• It is odorless, so it will not interfere with the aroma of the essential oils.
• It is rich in vitamins and fatty acids, which can help to nourish and protect the skin.
• It is less likely to irritate the skin than other carrier oils, such as coconut or olive oil.

Sweet almond oil is a suitable carrier for all skin types, including sensitive skin. It can be used to create a variety of essential oil blends, including blends for massage, aromatherapy, and skincare.

Here are some tips for using sweet almond oil as a carrier oil:

• Always do a patch test before using any new essential or carrier oil on your skin.
• Dilute essential oils properly before applying them to the skin. A good rule of thumb is to use 2-3 drops of essential oil per 1 teaspoon of carrier oil.
• Store sweet almond oil in a cool, dark place.
• Sweet almond oil can have a shelf life of up to 1 year.

If you are looking for a versatile and practical carrier oil, sweet almond oil is a good option. It is suitable for all skin types and can be used to create a variety of essential oil blends.")
        CarrierOils.Add("Avocado", "Avocado oil is a popular carrier oil for essential oils because it is rich in vitamins, minerals, and fatty acids. It is also non-comedogenic, meaning that it does not clog pores. Avocado oil is a good choice for people with all skin types, including dry, sensitive, and acne-prone skin.

Avocado oil has several benefits for the skin, including:

• Moisturizing: Avocado oil is a rich and emollient oil that helps to hydrate and soften the skin.
• Nourishing: Avocado oil is rich in vitamins A, B, D, and E, as well as minerals such as potassium and magnesium. These nutrients help to nourish and protect the skin.
• Anti-inflammatory: Avocado oil contains fatty acids that have anti-inflammatory properties. This can help to reduce redness and irritation.
• Healing: Avocado oil has been shown to promote wound healing.

When used as a carrier oil, avocado oil helps to dilute essential oils and make them safe for topical application. It also helps to carry the essential oils into the skin to absorb them and provide their therapeutic benefits.

To use avocado oil as a carrier oil, mix 2-3 drops of essential oil with 1 teaspoon of avocado oil. You can then apply the blend to your skin or diffuse it into the air.

Here are some ideas for using avocado oil as a carrier oil for essential oils:

• For dry skin: Mix a few drops of lavender essential oil with avocado oil and apply it to your skin after bathing or showering.
• For acne-prone skin: Mix a few drops of tea tree oil with avocado oil and apply it to your blemishes.
• For tired muscles: Mix a few drops of peppermint essential oil with avocado oil and massage it into your muscles.
• For relaxation: Mix a few drops of lavender or chamomile essential oil with avocado oil and diffuse it into the air.

If you are new to essential oils, it is vital to start with a low dilution and gradually increase the concentration as you become more comfortable. It is also important to do a patch test before using any new essential oil or carrier oil on your skin.")
        CarrierOils.Add("Apricot kernel", "Apricot kernel oil is a light, non-greasy carrier oil well-suited for all skin types. It is rich in vitamin A and essential fatty acids, which help to nourish and protect the skin. Apricot kernel oil is also a good source of antioxidants, which can help reduce aging signs.

Apricot kernel oil is a popular choice for carrier oil blends because it is easily absorbed into the skin and does not leave a greasy residue. It is also relatively affordable and easy to find.

Here are some of the benefits of using apricot kernel oil as a carrier oil:

• It is light and non-greasy, well-suited for all skin types.
• It is rich in vitamin A and essential fatty acids, which help to nourish and protect the skin.
• It is a good source of antioxidants, which can help reduce aging signs.
• It is easily absorbed into the skin and leaves no greasy residue.
• It is relatively affordable and easy to find.

Apricot kernel oil can be used to dilute essential oils for a variety of purposes, including:

• Massage: Apricot kernel oil is a popular choice for massage oil because it is easily absorbed into the skin and does not leave a greasy residue.
• Aromatherapy: To diffuse essential oils, mix a few drops of essential oil with 1 teaspoon of apricot kernel oil and add it to your diffuser.
• Topical application: To apply essential oils topically, mix a few drops of essential oil with 1 teaspoon of apricot kernel oil and apply it to the desired area of skin.

It is important to note that apricot kernel oil is a carrier oil and should not be ingested. Doing a patch test before using any new essential oil or carrier oil on your skin is also important.

If you are looking for a light, non-greasy carrier oil that is well-suited for all skin types, apricot kernel oil is a great option.")
        CarrierOils.Add("Argan", "Argan oil is a natural oil extracted from the kernels of the argan tree, which is native to Morocco. It is a popular carrier oil for essential oils because it is light, non-greasy, and easily absorbed by the skin. Argan oil is also rich in vitamin E and other essential fatty acids, which nourish and protect the skin.

Here are some of the benefits of using argan oil as a carrier oil:

• Argan oil is non-comedogenic, meaning that it will not clog pores. This makes it a good choice for people with acne-prone skin.
• Argan oil is rich in vitamin E and other essential fatty acids, which help to nourish and protect the skin.
• Argan oil is light and non-greasy, so it is easily absorbed by the skin. This makes it a good choice for using with essential oils, which can be irritating if applied directly to the skin.

Here are some tips for using argan oil as a carrier oil:

• Choose a high-quality, cold-pressed argan oil. Cold-pressed argan oil is the most gentle and effective way to extract the oil from the kernels, and it preserves the most nutrients.
• Store your argan oil in a cool, dark place. Argan oil can go rancid if it is exposed to heat or light.
• To use argan oil as a carrier, mix a few drops of essential oil with 1 teaspoon of argan oil. You can then apply the blend to your skin or diffuse it into the air.

Here is an example of how to use argan oil as a carrier oil to create a simple blend for dry skin:

• Mix 2 drops of lavender essential oil with 1 teaspoon of argan oil.
• Massage the blend into your skin, focusing on dry areas.
• You can also apply the blend to your hair to help hydrate and condition it.

Argan oil is a versatile and practical carrier oil that can be used with various essential oils to create blends for multiple purposes. If you are looking for a natural and nourishing carrier oil, argan oil is a great option.")
        CarrierOils.Add("Hazelnut", "Hazelnut oil is a popular carrier oil for essential oils because it is lightweight, non-greasy, and absorbs quickly into the skin. It is also a good source of vitamins and essential fatty acids, which can nourish and protect the skin.

Hazelnut oil is a good choice for people with all skin types, including oily and sensitive skin. It is also a good choice for people with acne-prone skin, as it is non-comedogenic.

Hazelnut oil can dilute essential oils before applying them to the skin for massage, aromatherapy, or other therapeutic purposes. It can also be used as a standalone moisturizer or added to other skincare products.

Here are some of the benefits of using hazelnut oil as a carrier oil:

• Lightweight and non-greasy: Hazelnut oil is a lightweight oil that absorbs quickly into the skin without leaving a greasy residue. This makes it a good choice for people with all skin types, including oily skin.
• Nourishing and protective: Hazelnut oil is a good source of vitamins and essential fatty acids, which can nourish and protect the skin. Vitamin E, in particular, is an antioxidant that can help to protect the skin from free radical damage.
• Non-comedogenic: Hazelnut oil is a non-comedogenic oil that will not clog pores. This makes it a good choice for people with acne-prone skin.
• Versatile: Hazelnut oil can dilute essential oils for massage, aromatherapy, or other therapeutic purposes. It can also be used as a standalone moisturizer or added to other skincare products.

To use hazelnut oil as a carrier oil, simply mix a few drops of essential oil with 1 teaspoon of hazelnut oil. You can then apply the blend to your skin or diffuse it into the air.

Here are some tips for using hazelnut oil as a carrier oil:

• Always do a patch test before using any new essential or carrier oil on your skin.
• If you have sensitive skin, start with a low dilution of essential oil in hazelnut oil. You can gradually increase the concentration as you become more comfortable.
• Avoid using hazelnut oil on broken or irritated skin.
• Store hazelnut oil in a cool, dark place.

If you are looking for a lightweight, non-greasy, and nourishing carrier oil for your essential oils, hazelnut oil is a great option.")
        CarrierOils.Add("Hemp seed", "Hemp seed oil is a popular carrier oil used in aromatherapy and skincare. It is a light, non-greasy oil that absorbs quickly into the skin. Hemp seed oil is also rich in essential fatty acids, which are beneficial for skin health.

Here are some of the benefits of using hemp seed oil as a carrier oil:

• Non-comedogenic: Hemp seed oil is non-comedogenic, meaning it will not clog pores. This makes it a good choice for people with acne-prone skin.
• Lightweight and non-greasy: Hemp seed oil is a lightweight, non-greasy oil that absorbs quickly into the skin. This makes it a comfortable oil to use, even on hot days.
• Rich in essential fatty acids: Hemp seed oil is rich in essential fatty acids, such as omega-3 and omega-6. These fatty acids are beneficial for skin health, as they can help moisturize the skin, reduce inflammation, and improve the skin's barrier function.
• Good for sensitive skin: Hemp seed oil is a good choice for people with sensitive skin. It is gentle and non-irritating.

Hemp seed oil can dilute essential oils before applying them to the skin. It can also be used as a moisturizer or massage oil.

Mix 2-3 drops of essential oil with 1 teaspoon of hemp seed oil to make a basic essential oil blend. You can then apply the mixture to your skin or diffuse it into the air.

If you are new to essential oils, it is crucial to start with a low dilution and gradually increase the concentration as you become more comfortable. Doing a patch test before using any new essential oil or carrier oil on your skin is also important.

Here are some examples of how to use hemp seed oil as a carrier oil:

• For aromatherapy: Add a few drops of your favorite essential oil to a diffuser with hemp seed oil to enjoy the aroma.
• For massage: Mix a few drops of essential oil with hemp seed oil and use it for a relaxing massage.
• For skincare: Apply a few drops of hemp seed oil to your skin as a moisturizer or cleanser.

Hemp seed oil is a versatile and beneficial carrier oil that can be used in a variety of ways.")
        CarrierOils.Add("Sunflower", "Sunflower oil is a popular carrier oil for essential oils because it is lightweight, non-greasy, and has a neutral odor. It is also relatively inexpensive and easy to find. Sunflower oil is a good choice for all skin types, including sensitive skin.

Sunflower oil is rich in vitamin E, an antioxidant that can help protect the skin from damage. It is also a good source of fatty acids, which can help moisturize the skin.

To use sunflower oil as a carrier oil, mix a few drops of essential oil with 1 teaspoon of sunflower oil. You can then apply the blend to your skin or diffuse it into the air.

Here are some of the benefits of using sunflower oil as a carrier oil:

• It is lightweight and non-greasy, so it is not likely to clog pores.
• It has a neutral odor, so it will not interfere with the aroma of the essential oils you are using.
• It is relatively inexpensive and easy to find.
• It is a good choice for all skin types, including sensitive skin.
• It is rich in vitamin E and fatty acids, which benefit the skin.

Here are some tips for using sunflower oil as a carrier oil:

• Always dilute essential oils with a carrier oil before applying them to the skin.
• Start with a low dilution and gradually increase the concentration as you become more comfortable.
• Do a patch test before using any new essential or carrier oil on your skin.
• Store sunflower oil in a cool, dark place.

If you are looking for a lightweight, non-greasy, and affordable carrier oil for essential oils, sunflower oil is a good option. It is also a good choice for people with all skin types, including sensitive skin.")
        CarrierOils.Add("Olive", "Olive oil is a popular carrier oil for essential oils because it is readily available, affordable, and has a relatively neutral scent. It is also a good source of vitamin E, an antioxidant that can help protect the skin from damage.

However, there are a few things to keep in mind when using olive oil as a carrier oil:

• Olive oil is a thick oil that can slowly absorb into the skin. This may not be ideal for people with oily skin or who use essential oils for their therapeutic benefits.
• Olive oil can also be comedogenic and can clog pores. People with acne-prone skin may want to choose a different carrier oil, such as jojoba oil or grapeseed oil.
• Olive oil has a relatively low shelf life, so storing it in a cool, dark place and using it within a few months of opening is essential.

If you choose to use olive oil as a carrier, be sure to dilute your essential oils properly. Mix 2-3 drops of essential oil with 1 teaspoon of olive oil for a basic blend. You can then apply the combination to your skin or diffuse it into the air.

Here are some tips for using olive oil as a carrier oil:

• Choose a high-quality olive oil. Avoid using olive oil that has been cooked or used for cooking, as this can reduce its quality and effectiveness.
• Warm the olive oil slightly before blending it with your essential oils. This will help the two oils to mix more easily.
• Do a patch test before using any new essential or carrier oil on your skin. To do a patch test, mix a small amount of the essential oil with olive oil and apply it to a small area of skin on the inside of your forearm. Wait 24 hours to see if there is any reaction.
• Avoid using olive oil as a carrier oil on sensitive areas of the skin, such as the face, eyes, and genitals.

If you have any concerns about using olive oil as a carrier oil, be sure to talk to your doctor.")
        CarrierOils.Add("Castor", "Castor oil is a versatile oil that can be used for various purposes, including as a carrier oil for essential oils. It is a thick, viscous oil that is extracted from the seeds of the Ricinus communis plant. Castor oil has many beneficial properties, including:

• Antibacterial and antifungal: Castor oil has antibacterial and antifungal properties, which can help to keep the skin healthy and free from infection.
• Anti-inflammatory: Castor oil has anti-inflammatory properties, which can help to reduce redness and swelling.
• Moisturizing: Castor oil is a good moisturizer for the skin and hair.
• Stimulating: Castor oil can help to stimulate circulation and promote hair growth.

Castor oil can be used as a carrier oil for essential oils because it can penetrate the skin and deliver the essential oils to the deeper layers of tissue. Castor oil is also a good choice for carrier oils because it is relatively inexpensive and easy to find.

However, there are a few things to keep in mind when using castor oil as a carrier oil:

• Castor oil is a thick oil that can slowly absorb into the skin. This may not be ideal for people with oily skin or who use essential oils for their therapeutic benefits.
• Castor oil can also be comedogenic, meaning it can clog pores. People with acne-prone skin may want to choose a different carrier oil, such as jojoba oil or grapeseed oil.
• Castor oil can irritate the skin significantly if it is not diluted correctly. Diluting castor oil well before applying it to the skin is essential.

If you choose castor oil as a carrier oil, dilute it properly. Mix 1 drop of essential oil with 1 teaspoon of castor oil for a basic blend. You can then apply the combination to your skin or diffuse it into the air.

Here are some tips for using castor oil as a carrier oil:

• Choose a high-quality castor oil. Avoid using castor oil that has been cooked or used for cooking, as this can reduce its quality and effectiveness.
• Warm the castor oil slightly before blending it with your essential oils. This will help the two oils to mix more easily.
• Do a patch test before using any new essential or carrier oil on your skin. To do a patch test, mix a small amount of the essential oil with castor oil and apply it to a small area of skin on the inside of your forearm. Wait 24 hours to see if there is any reaction.
• Avoid using castor oil as a carrier oil on sensitive areas of the skin, such as the face, eyes, and genitals.

If you have concerns about using castor oil as a carrier oil, talk to your doctor.

Additionally, it is important to note that castor oil is a laxative and should not be ingested.")
        If CarrierOils.TryGetValue(e, e) Then
        Else
            e = ""
        End If
        Return e
    End Function

End Module
