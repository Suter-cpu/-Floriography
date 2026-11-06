using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Floriography.Models;

namespace Floriography.Controllers
{
	public class FlowersController : Controller
	{
		public ActionResult Index()
		{
			List<FlowerModel> flowers = GetFlowerData();
			// Shuffle the list so users see different flowers first
			var shuffledFlowers = flowers.OrderBy(x => Guid.NewGuid()).ToList();
			return View(shuffledFlowers);
		}

		private List<FlowerModel> GetFlowerData()
		{
			var list = new List<FlowerModel>();

			// REFINED HELPER: Now only takes Letter, Name, Meaning, and your Local Filename
			void Add(char l, string n, string m, string fileName) =>
				list.Add(new FlowerModel
				{
					Letter = l,
					Name = n,
					Meaning = m,
					ImageUrl = $"~/Project Images/{fileName}"
				});

			// --- A ---
			Add('A', "Anemone", "Has Anticipation and fragility", "flo_Anemone.jpg");
			Add('A', "Amaryllis", "Has Splendid beauty and pride", "flo_Amaryllis.jpg");
			Add('A', "Aster", "Symbol of love and daintiness", "flo_Asters.jpg");
			Add('A', "Azalea", "Take care of yourself", "flo_Azalea.jpg");
			Add('A', "Alstroemeria", "Devotion to friendship", "flo_alstroemeria.jpg");


			// --- B ---
			Add('B', "Begonia", "Beware of dark thoughts", "flo_begonia.jpg");
			Add('B', "Bluebell", "Has Humility and constancy", "flo_bluebell.jpg");
			Add('B', "Baby's Breath", "Will find Everlasting love", "flo_babysbreath.jpg");
			Add('B', "Buttercup", "Got Radiance with charm", "flo_buttercup.jpg");
			Add('B', "Bachelor Button", " Has Single blessedness", "flo_bachelorbutton.jpg");


			// --- C ---
			Add('C', "Chrysanthemum", "Is Loyal and devoted in love", "flo_chrysanthemum.jpg");
			Add('C', "Carnation", "Admires Quietly", "flo_carnation.jpg");
			Add('C', "Calla Lily", "Has Elegance and purity", "flo_callalily.jpg");
			Add('C', "Camellia", "Has Admiration and is a perfectionist", "flo_camellia.jpg");
			Add('C', "Crocus", " Got Youthful gladness", "flo_crocus.jpg");

			// --- D ---
			Add('D', "Daffodil", " Belive In possibilites of New beginnings and Rebirth", "flo_daffodil.jpg");
			Add('D', "Dahlia", " Acquire More Elegance and dignity", "flo_dahlia.jpg");
			Add('D', "Daisy", "This feels simple and honest", "flo_daisy.jpg");
			Add('D', "Delphinium", " Have a Big-Heart", "flo_delphinium.jpg");
			Add('D', "Dandelion", "Don't you EVER stop wishing happiness", "flo_dandelion.jpg");


			//--E--

			Add('E', "Edelweiss", "Has Courage and Devotion", "flo_edelweiss.jpg");
			Add('E', "Echinacea", "Shows Strength and health", "flo_echinacea.jpg");
			Add('E', "Eucalyptus", "Carries the power to Protect and heal", "flo_eucalyptus.jpg");
			Add('E', "Eustoma", "Is Outgoing and friendly", "flo_eustoma.jpg");
			Add('E', "Evening Primrose", "Stop being Inconstancy", "flo_evening_primrose.jpg");



			// --- F ---

			Add('F', "Forget-Me-Not", "True love and memories", "flo_forget_me_not.jpg");
			Add('F', "Freesia", " Have Trust and innocence", "flo_freesia.jpg");
			Add('F', "Foxglove", "Stop being Insincere and full of riddles", "flo_foxglove.jpg");
			Add('F', "Forsythia", "Stop the Anticipation over Chaos", "flo_forsythia.jpg");
			Add('F', "Frangipani", "Stands Beautiful even through the heat of Summer", "flo_frangipani.jpg");


			//---G---
			Add('G', "Gardenia", " Has a Secret love and purity", "flo_gardenia.jpg");
			Add('G', "Geranium", "Has Gentility and stupidity", "flo_geranium.jpg");
			Add('G', "Gladiolus", "Show the Strength of character", "flo_gladiolus.jpg");
			Add('G', "Goldenrod", "Give Encouragement but also be cautious", "flo_goldenrod.jpg");
			Add('G', "Gerbera Daisy", "Always be Cheerful", "flo_gerbera_daisy.jpg");


			//--H---

			Add('H', "Hyacinth", "Sincerity and constancy", "flo_hyacinth.jpg");
			Add('H', "Hydrangea", "I feel more than I say", "flo_hydrangea.jpg");
			Add('H', "Holly", "Defense and domestic happiness", "flo_holly.jpg");
			Add('H', "Honeysuckle", "Devotion and affection", "flo_honeysuckle.jpg");
			Add('H', "Hibiscus", "Delicate beauty", "flo_hibiscus.jpg");


			//--I--
			Add('I', "Iris", "Wisdom, hope, and trust", "flo_iris.jpg");
			Add('I', "Ivy", "Fidelity and friendship", "flo_ivy.jpg");
			Add('I', "Iceland Poppy", "Consolation", "flo_icelandpoppy.jpg");
			Add('I', "Immortelle", "Stands tall, unyielding against time.", "flo_immortelle.jpg");
			Add('I', "Impatiens", "Motherly love for others", "flo_impatiens.jpg");


			//--J--

			Add('J', "Jasmine", "Unconditional love and modesty", "flo_jasmine.jpg");
			Add('J', "Jonquil", "Affection returned", "flo_jonquil.jpg");
			Add('J', "Juniper", "Protection", "flo_juniper.jpg");
			Add('J', "Japanese Maple", "Great reserve", "flo_japanesemaple.jpg");
			Add('J', "Jewelweed", "Impatient", "flo_jewelweed.jpg");



			//--K--
			Add('K', "Kalmia", "Ambitious and has perseverance", "flo_kalmia.jpg");
			Add('K', "King Protea", "Diversity and courage", "flo_kingprotea.jpg");
			Add('K', "Kangaroo Paw", "Unique", "flo_kangaroopaw.jpg");
			Add('K', "Knapweed", "Have Hope", "flo_knapweed.jpg");
			Add('K', "Kalanchoe", "Be Persistent", "flo_kalanchoe.jpg");



			//--L--
			Add('L', "Lavender", "Devotion, serenity, and grace", "flo_lavender.jpg");
			Add('L', "Lily", "I dare you to love me", "flo_lily.jpg");
			Add('L', "Lilac", "First emotions of love", "flo_lilac.jpg");
			Add('L', "Lotus", "Purity and enlightenment", "flo_lotus.jpg");
			Add('L', "Larkspur", "Has an open heart", "flo_larkspur.jpg");


			//--M--
			Add('M', "Marigold", "Joy, warmth, and creative", "flo_marigold.jpg");
			Add('M', "Magnolia", "Nobility and dignity", "flo_magnolia.jpg");
			Add('M', "Mimosa", "Sensitive", "flo_mimosa.jpg");
			Add('M', "Myrtle", "Love and Hebrew emblem of marriage", "flo_myrtle.jpg");
			Add('M', "Morning Glory", "Affection and unrequited love", "flo_morningglory.jpg");

			//--N--
			Add('N', "Narcissus", "Stay as sweet as you are", "flo_narcissus.jpg");
			Add('N', "Nasturtium", "Conquest and victory", "flo_nasturtium.jpg");
			Add('N', "Nightshade", "Silent", "flo_nightshade.jpg");
			Add('N', "Nerine", "Awaiting a letter", "flo_nerine.jpg");
			Add('N', "Nicotiana", "You are not alone", "flo_nicotiana.jpg");

			//--O--
			Add('O', "Orchid", "Refined beauty and strength", "flo_orchid.jpg");
			Add('O', "Oleander", "Beware and cautious", "flo_oleander.jpg");
			Add('O', "Orange Blossom", "Innocence and eternal love", "flo_orangeblossom.jpg");
			Add('O', "Osteospermum", "Purity and innocence", "flo_osteospermum.jpg");
			Add('O', "Oxeye Daisy", "Patience", "flo_oxeyedaisy.jpg");

			//--P--
			Add('P', "Peony", "Bashfulness and prosperity", "flo_peony.jpg");
			Add('P', "Pansy", "Thinking and remembrance", "flo_pansy.jpg");
			Add('P', "Poppy", "Restful sleep and consolation", "flo_poppy.jpg");
			Add('P', "Petunia", "Resentment and anger", "flo_petunia.jpg");
			Add('P', "Primrose", "I can't live without you", "flo_primrose.jpg");

			//--Q--
			Add('Q', "Queen Anne's Lace", "Sanctuary and complexity", "flo_queenanneslace.jpg");
			Add('Q', "Quince", "Temptation", "flo_quince.jpg");
			Add('Q', "Quaking Grass", "Agitation", "flo_quakinggrass.jpg");
			Add('Q', "Queen Protea", "Dignity and courage", "flo_queenprotea.jpg");
			Add('Q', "Qualia", "Mystery", "flo_qualia.jpg");

			//--R--
			Add('R', "Rose", "Love, passion, and beauty", "flo_rose.jpg");
			Add('R', "Ranunculus", "Radiant charm", "flo_ranunculus.jpg");
			Add('R', "Rhododendron", "Danger and beware", "flo_rhododendron.jpg");
			Add('R', "Rosemary", "Remembrance", "flo_rosemary.jpg");
			Add('R', "Red Clover", "Attain Good Health", "flo_redclover.jpg");

            //--S--
            Add('S', "Sunflower", "Adored and loyal", "flo_sunflower.jpg");
            Add('S', "Snapdragon", "Have Strength and be grace", "flo_snapdragon.jpg");
            Add('S', "Sweet Pea", "Displays Pleasure and gratitude", "flo_sweetpea.jpg");
            Add('S', "Snowdrop", "Have Hope and consolation", "flo_snowdrop.jpg");
            Add('S', "Statice", "Remembrance and sympathy", "flo_statice.jpg");


            //--T--
            Add('T', "Tulip", "Declaration of perfect love", "flo_tulip.jpg");
            Add('T', "Thistle", "Austerity", "flo_thistle.jpg");
            Add('T', "Tuberose", "Dangerous pleasure", "flo_tuberose.jpg");
            Add('T', "Trillium", "Modest beauty", "flo_trillium.jpg");
            Add('T', "Tansy", "Hostility", "flo_tansy.jpg");


            //--U--
            Add('U', "Ursinia", "Innocence and pure love", "flo_ursinia.jpg");
            Add('U', "Umbel", "Purity", "flo_umbel.jpg"); 
            Add('U', "Ulex", "Enduring affection", "flo_ulex.jpg");
            Add('U', "Uvularia", "Have Grace", "flo_uvularia.jpg");
            Add('U', "Umbrella Plant", "Protect yourself from bad omen", "flo_umbrellaplant.jpg");

            //--V--
            Add('V', "Violet", "Is Faithful and modest", "flo_violet.jpg");
            Add('V', "Verbena", "Sensibility", "flo_verbena.jpg");
            Add('V', "Venus Flytrap", "Deceit", "flo_venusflytrap.jpg");
            Add('V', "Valerian", "Hidden Strength", "flo_valerian.jpg");
            Add('V', "Vinca", "Early friendship coming", "flo_vinca.jpg");


            //--W--
            Add('W', "Wisteria", "Welcome longevity", "flo_wisteria.jpg");
            Add('W', "Wallflower", "Fidelity in adversity", "flo_wallflower.jpg");
            Add('W', "Water Lily", "Pure of heart", "flo_waterlily.jpg");
            Add('W', "Wild Rose", "Simplicity", "flo_wildrose.jpg");
            Add('W', "Witch Hazel", "A Bad spell is upon you", "flo_witchhazel.jpg");


            //--X--
            Add('X', "Xeranthemum", "Eternity and immortality could be yours", "flo_xeranthemum.jpg");
            Add('X', "Xylosma", "Gentle spirit", "flo_xylosma.jpg");
            Add('X', "Xyris", "Sunshine", "flo_xyris.jpg");
            Add('X', "Xenia", "Hospitality", "flo_xenia.jpg");
            Add('X', "Xanthorrhoea", "Endurance", "flo_xanthorrhoea.jpg");


            //--Y--
            Add('Y', "Yarrow", "Everlasting love and healing", "flo_yarrow.jpg");
            Add('Y', "Yellow Rose", "Friendship and joy", "flo_yellowrose.jpg");
            Add('Y', "Yellow Tulip", "Cheerful thoughts", "flo_yellowtulip.jpg");
            Add('Y', "Yellow Jasmine", "Grace and elegance", "flo_yellowjasmine.jpg");
            Add('Y', "Yucca", "Opportunity is on its way", "flo_yucca.jpg");


            //--Z--
            Add('Z', "Zinnia", "Thinks of absent friends", "flo_zinnia.jpg");
            Add('Z', "Zephyranthes", " Expects Expectation ", "flo_zephyranthes.jpg");
            Add('Z', "Zamia", "Shows Elegance", "flo_zamia.jpg");
            Add('Z', "Zygopetalum", "Spiritual love", "flo_zygopetalum.jpg");
            Add('Z', "Zoysia", "Remember who you are.", "flo_zoysia.jpg");


            return list;
		}

        public ActionResult EnterName()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NameResult(string userName)
        {
            var allFlowers = GetFlowerData();
            var result = new List<FlowerModel>();
            var random = new Random();

            foreach (char letter in userName.ToUpper())
            {
                var matchingFlowers = allFlowers
                    .Where(f => f.Letter == letter)
                    .ToList();

                if (matchingFlowers.Count > 0)
                {
                    var randomFlower = matchingFlowers[random.Next(matchingFlowers.Count)];
                    result.Add(randomFlower);
                }
            }

            ViewBag.UserName = userName;
            return View(result);
        }
    }
}
