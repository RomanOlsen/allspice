<script setup>
import Create from '@/components/Create.vue';
import { recipesService } from '@/services/RecipesService.js';
import { logger } from '@/utils/Logger.js';
import { Pop } from '@/utils/Pop.js';
import { onMounted } from 'vue';

onMounted(() => {
  getAllRecipes()
})

async function getAllRecipes() {
  try {
    await recipesService.getAllRecipes()
  }
  catch (error) {
    Pop.error(error, 'could not get recipes!');
    logger.log("could not get recipes", error)
  }
}

</script>

<template>
  <div class="container">
    <div class="row">
      <div class="col-12 d-flex justify-content-center">
        <div class="text-center choose-section bg-light rounded shadow">
          <!-- <div class="position-relative"> -->

          <button class="btn btn-light">Home</button>
          <button class="btn btn-light">My Recipes</button>
          <button class="btn btn-light">Favorites</button>
          <!-- </div> -->

        </div>
      </div>
      <div class="col-12">
        <p>Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ab ipsa nobis quae dolorem commodi accusantium
          libero nulla ad inventore eligendi est quaerat repudiandae sunt excepturi, cum veritatis facere soluta amet
          mollitia aperiam accusamus, voluptate quas magnam. Rem nisi architecto dolorum animi ea adipisci, facilis
          officiis delectus aspernatur quos vel incidunt, nobis iure est tenetur nesciunt, sequi illo labore
          praesentium? Dignissimos pariatur cumque doloribus, accusamus odit dolores natus aut repellat ipsum inventore
          assumenda illum facere distinctio ducimus explicabo sed saepe debitis commodi officiis adipisci provident? Ut
          aliquid, architecto quo ipsam ab atque tempora hic facere error? Eius quasi iusto minima? Error odio
          doloribus, ducimus quae quod eaque cum ab asperiores distinctio magnam, in mollitia sequi? Nam expedita nulla,
          eum dolorum numquam voluptate? Aut, delectus tempore. Optio dolore dignissimos expedita corrupti tempore illum
          dolorem ipsam. Ducimus natus corrupti molestias beatae saepe tenetur illo mollitia excepturi ratione
          reiciendis! Quo aliquid, magnam dignissimos hic nam dolorem vero optio alias quae quod dolore pariatur cum
          atque. Accusamus, reprehenderit velit porro quod laboriosam in quam non magnam asperiores dolore, veritatis
          quas! Officiis eius voluptate ex et facere modi odio fugiat officia illo beatae quasi explicabo totam
          perspiciatis asperiores ullam necessitatibus libero aliquam, temporibus corrupti nesciunt? Cumque sed animi
          facere perferendis tenetur obcaecati? Autem, quibusdam. Nobis corporis nostrum aliquid iusto, id sequi fugiat
          incidunt fuga quos necessitatibus! Velit impedit recusandae corrupti beatae facere odit dolor natus sequi
          similique, ab laudantium laborum quam eos repudiandae magnam! Quibusdam voluptas repellat possimus quis,
          distinctio et consequuntur odio a tempora perferendis ea, quo voluptatum sunt officiis voluptatem quae eos
          similique laboriosam repellendus, eius atque dolorum ullam magnam! Perspiciatis placeat quo aliquam hic harum
          consequuntur ex tenetur, ullam voluptate earum laudantium assumenda, saepe praesentium, blanditiis perferendis
          temporibus officiis porro nobis minus cupiditate iure error quisquam! Velit, necessitatibus officia eligendi
          asperiores animi veniam distinctio officiis aut ad molestias maiores omnis eum veritatis ratione tempora autem
          sit nemo modi illum quibusdam culpa assumenda, magnam mollitia cumque. Repudiandae harum ratione totam
          corporis quasi et commodi aliquid animi adipisci vel. Ab ut cumque beatae? Itaque beatae atque dicta vel
          repellendus molestiae, commodi accusantium expedita praesentium eveniet minima, veniam nam earum consectetur
          cupiditate esse quis molestias quae doloribus excepturi nobis quaerat voluptas. Deleniti, repellendus
          delectus. Corporis odit placeat, in dolorum veritatis ex, voluptates dignissimos quas iusto eius tenetur
          beatae animi, vel quos. Illo molestias deleniti placeat consequuntur illum facere ducimus perspiciatis quis
          necessitatibus? Accusamus, velit aliquam, vero facere magni labore sit numquam temporibus, totam quis ut
          aliquid corrupti qui eveniet. Dolorum, adipisci fugit, deserunt et sequi illum unde aliquid quibusdam quas est
          labore impedit vel odit magnam officiis sapiente minima voluptas animi eveniet itaque. Ipsum necessitatibus
          ducimus facere cum nihil! Mollitia sit incidunt commodi assumenda neque, magni, obcaecati blanditiis pariatur
          voluptatibus beatae distinctio perspiciatis dolor voluptatem eum tempore similique illo harum quas est!
          Beatae, quos rem! Exercitationem, ex beatae? Quod enim soluta incidunt velit corporis laborum ab voluptate vel
          vitae iste. Laboriosam impedit saepe ratione est at! Dolore quo nisi pariatur neque quos eaque iste eius nulla
          omnis nostrum earum, maxime animi accusamus labore voluptatibus eum natus ea laudantium obcaecati dicta vero
          deleniti consequuntur expedita ad? At dolore earum porro consequuntur assumenda similique a exercitationem
          unde obcaecati error recusandae id, dignissimos tempora iste explicabo et quibusdam rerum cupiditate nesciunt
          iusto nostrum sint ex? Placeat sunt omnis dolor veniam. Esse, accusantium aliquid. Quidem, minus? Cum, tenetur
          exercitationem molestias asperiores laborum pariatur impedit consectetur aperiam ipsam animi molestiae nobis
          voluptatibus eaque delectus adipisci iure nisi eveniet dignissimos minus nulla libero similique officia.
          Omnis, nam dolorum. Temporibus suscipit repellat praesentium nisi quas aperiam accusantium non autem aliquid
          quae natus minima vel cum delectus quam tempora repudiandae, eos numquam ipsa necessitatibus? Ab, incidunt
          delectus voluptates modi necessitatibus laboriosam, sequi vero eveniet eaque a itaque corporis quibusdam
          numquam quisquam quia porro omnis iure, deserunt cum ex cupiditate. Molestias dignissimos incidunt ipsa iusto
          quia soluta a, illum cumque quam ipsum doloremque amet, nesciunt repellendus voluptates sapiente officiis
          quibusdam exercitationem excepturi commodi explicabo praesentium tenetur sequi. Minima, ea eaque distinctio,
          fuga fugiat reprehenderit suscipit obcaecati est eum ducimus deserunt at. Voluptatibus alias veniam sunt
          cumque nam architecto perspiciatis tenetur assumenda dolorem quo ab accusamus ipsam earum laboriosam rerum ea
          officiis ratione nihil libero, voluptates modi harum, veritatis est beatae? Sit cupiditate, ex quasi repellat
          ut, error est iste eos velit, reprehenderit similique esse consequatur obcaecati nisi ullam laudantium.
          Excepturi esse totam cum veritatis veniam beatae perferendis culpa, adipisci vel repellat voluptas at
          consequatur nesciunt sunt. Dolorem fugiat perferendis quibusdam, vel quasi unde cum non iusto fugit. Et beatae
          a laboriosam perspiciatis culpa praesentium magnam explicabo neque! Nemo exercitationem odio deleniti
          repellendus. Nemo voluptas non officiis illo magni, ipsum magnam? Beatae non nobis placeat a deleniti illo
          sint eligendi unde alias similique, numquam vel labore mollitia animi velit quis, facilis dolores voluptatem
          magni ducimus. Tempora impedit, possimus ratione sint autem doloribus a architecto nostrum assumenda
          consectetur quaerat velit, nesciunt praesentium nulla iure nihil voluptatem nam nobis expedita mollitia ipsa,
          fugit atque excepturi! Vero, totam culpa eius obcaecati dignissimos omnis vitae nostrum. Neque, necessitatibus
          eum cum fugiat eligendi minus quis suscipit facere aliquam reiciendis accusamus minima sint, eius illum,
          inventore deserunt error nisi iusto! Veniam culpa facere dolore voluptates maiores consequatur, corrupti
          veritatis ex magni eos rerum quasi sit nam, quaerat inventore saepe dolorem error aspernatur perferendis ipsum
          quisquam ipsa. Aspernatur fuga dolores sint! Dolores molestias cupiditate vitae provident voluptatum
          architecto? Excepturi incidunt eius minus sapiente. Unde soluta in deserunt possimus? Nulla accusantium
          dolorem, quisquam numquam ipsa id ipsam nesciunt error impedit itaque facere pariatur omnis aliquid rem ea
          quia debitis placeat quam blanditiis dignissimos. Eaque minus unde quidem libero asperiores quod optio quaerat
          dolore vero laboriosam perferendis quia suscipit, nesciunt quasi pariatur nostrum voluptas officiis,
          voluptatum illo fuga. Fuga neque quibusdam omnis aliquid quisquam nesciunt labore at deserunt suscipit quis,
          hic voluptatibus doloribus sunt, eius atque, magnam ipsam id distinctio culpa. Ea, doloribus! Minus beatae,
          doloribus commodi, quibusdam eum ratione tenetur corporis a impedit cumque ullam iste? Provident cumque neque
          enim labore porro molestias rem et velit culpa voluptatum saepe nihil expedita magnam, aliquid accusantium
          atque dolore debitis. Non maiores beatae molestias, architecto nam reprehenderit soluta maxime autem
          consequatur suscipit aliquid iusto sapiente cumque voluptate, consectetur officiis. Accusamus doloribus,
          fugiat quos necessitatibus distinctio facere dignissimos ullam aut odit vel sequi ipsum est maiores, suscipit
          odio esse, sunt repudiandae ab nostrum. Placeat amet dolores modi. Molestias quia possimus sequi qui ipsa
          magnam accusamus exercitationem inventore doloremque at dicta laborum a quisquam cum aliquam, eos minus quam?
          Pariatur accusantium libero aliquam nisi ipsum nobis quo ratione dolorem repellat soluta a corporis fugiat
          porro omnis, beatae quaerat sed modi! Tenetur natus explicabo recusandae in. Ratione, voluptatibus? Iure,
          unde. Molestiae error corporis nesciunt, rem sit eius quod asperiores suscipit cupiditate provident ad ex
          voluptatibus quisquam, ipsa itaque labore necessitatibus minus repudiandae fuga amet, blanditiis soluta
          sapiente atque! Molestiae reiciendis cupiditate error quasi laboriosam eveniet cum architecto. Quas quasi ea
          repudiandae facilis cumque nam ratione temporibus eligendi perferendis repellat excepturi id consectetur ipsam
          enim, illo at, in quia rerum numquam facere error, dignissimos quae obcaecati accusantium. Voluptates, est
          fugit. Maiores dicta quisquam, sed eum tempore magnam facere veritatis veniam. Aliquid sint ad harum atque
          velit quia quis hic iure ipsa, necessitatibus ullam veritatis provident modi consectetur numquam. Veniam
          tempore placeat at enim ut quae harum temporibus totam beatae hic, praesentium delectus fugit est, accusamus,
          eius eum deleniti repellat id possimus sit amet unde impedit esse? Nihil deleniti laborum fuga ipsum rem vitae
          porro molestiae, id consequuntur culpa excepturi quae perspiciatis corporis delectus cupiditate est inventore
          voluptatum, aliquid incidunt asperiores at. Velit temporibus iure assumenda vero omnis blanditiis eos aut,
          quos commodi dolores dolore excepturi id optio nisi asperiores quod voluptates, soluta corrupti veniam
          nostrum, aperiam obcaecati. Sed labore in reprehenderit laborum vel voluptas dolorem praesentium maiores
          itaque porro aperiam fugit nisi ab deleniti culpa, recusandae voluptatem, perferendis nobis, molestias quod
          eius delectus. Quidem dolorem, perferendis, totam culpa aspernatur fuga neque tempore eligendi molestiae
          commodi doloribus architecto est eveniet nobis, incidunt et quisquam cumque veniam modi natus enim consectetur
          omnis! Voluptatem repellendus magnam quaerat! Autem quas eos reprehenderit ratione perspiciatis, accusantium
          ad quos ex nisi iure esse aliquam! Blanditiis, accusamus obcaecati eligendi, ipsum praesentium a nulla
          necessitatibus repudiandae neque alias id asperiores nobis sint commodi iusto. Nihil nulla cum nisi nemo
          repellat, maiores aspernatur eveniet quisquam ducimus saepe vel voluptas quia temporibus ex tempore optio
          adipisci accusantium maxime, eum dolorum. Assumenda earum nihil beatae vel nemo iste laboriosam cupiditate
          quae natus. Corporis deleniti cum quod sed perspiciatis atque quis ea adipisci nulla corrupti! Eum sunt ipsam
          explicabo quam molestias odio eveniet. Aut ad sequi, commodi voluptas magnam dignissimos esse quo. Cum magnam
          fugiat corporis. Nulla placeat vitae minima ea expedita dolorem amet eligendi dolores animi cumque,
          repudiandae enim accusamus ab deserunt atque exercitationem cupiditate et maiores est quam doloribus modi ad.
          Minima, sit itaque? Numquam quaerat molestias facere eos hic dolor voluptatibus totam autem? Consequuntur
          dolore similique ex? Accusantium minima quaerat impedit earum magni dignissimos, porro ea expedita consequatur
          quo hic cumque eligendi saepe quas! Dolores cupiditate earum hic nihil, sint explicabo ipsa dolorum vitae
          necessitatibus nostrum accusantium, esse sed excepturi tempora ratione! Ducimus eos at sunt dignissimos error
          doloremque reiciendis ullam tempore similique dolores corrupti soluta voluptas obcaecati libero autem illo,
          facere iure natus iste aut. Quam ipsa vel, architecto possimus nisi ut asperiores placeat magnam minima
          perferendis excepturi aliquam quas temporibus recusandae! Voluptatum, beatae. Saepe cumque fuga ex id nulla ut
          veniam? Eligendi esse nemo eos praesentium ex quaerat. Impedit ut sit dolore. Explicabo impedit, libero nam
          voluptatibus beatae illo earum minus ex rerum provident ducimus! Quas minus nulla omnis quaerat nisi,
          temporibus voluptatibus maiores! Et sequi explicabo, ea, sint ducimus doloremque suscipit ipsa optio assumenda
          architecto accusantium sit, aliquam a ipsum inventore aspernatur quam delectus facilis nam. Inventore maiores
          ea quod, tenetur, quibusdam tempore odio, adipisci nobis nisi facilis sed libero accusantium soluta. Totam,
          ipsum. Nihil voluptatem, fuga atque, omnis enim reprehenderit tempore doloremque non harum esse earum. Velit
          rerum nam sapiente, quod fugit nisi! A eligendi quasi, ducimus ad quibusdam quam officiis expedita assumenda
          vel voluptatem. Provident iure itaque, fugit officiis quis ex nulla. Quas aperiam praesentium eos
          necessitatibus pariatur ab rerum mollitia quam iusto omnis, molestias commodi dignissimos voluptatibus nisi
          perferendis maxime nulla asperiores odio laudantium similique aliquid cum? Deserunt eum saepe accusantium
          veniam amet tempore modi est accusamus a magni esse minus soluta sint, voluptatum voluptatem vel quam officiis
          quos earum aut. Reiciendis, fugit deleniti aspernatur non quis accusamus reprehenderit recusandae aperiam quia
          perspiciatis suscipit magnam deserunt? Incidunt quisquam assumenda possimus magni culpa est? Saepe, pariatur?
          Excepturi illum, consequatur voluptates iusto iste expedita fuga est suscipit dolores, ea dolor magnam error
          ratione tenetur delectus, cupiditate deserunt? Sit beatae ipsum quibusdam veniam numquam excepturi ut magni
          assumenda voluptatem, sunt fuga consectetur dolore doloribus sapiente minima odit unde praesentium qui.
          Temporibus deserunt dolore quisquam. Rem corporis beatae, optio praesentium consectetur consequuntur et
          suscipit repudiandae nihil dolores voluptate a. Velit corrupti vel doloribus sequi! Sint possimus repudiandae
          eos corporis illo temporibus veniam sed. Autem magni expedita, id ex cupiditate impedit blanditiis,
          consectetur accusamus reprehenderit voluptate velit suscipit alias aliquam in quibusdam vel quam, fuga tenetur
          dolore. Nisi error eligendi quidem. Nobis quaerat cumque totam explicabo! Sit facilis quas ut, non labore
          fugiat ullam totam soluta, iure nam nemo pariatur optio at aspernatur. Et vitae aspernatur est voluptatibus
          ut, aut dolores quidem aliquid dolor, itaque perspiciatis qui assumenda nulla nobis dolorem, aperiam alias.
          Tempora laborum non itaque iusto architecto rem aut iste quos in cumque minima sequi nisi similique, nulla
          autem dicta dignissimos blanditiis? Facilis hic nemo ipsa, ex cum atque unde mollitia! Doloribus omnis dolores
          sed pariatur iure laboriosam, exercitationem eum magnam alias nulla sequi quaerat ipsum deleniti blanditiis,
          veritatis quidem nam sint nemo corrupti consequatur dicta aliquid consequuntur? Amet atque debitis rerum
          facilis porro, non rem nesciunt delectus ea voluptatem asperiores veniam laborum veritatis earum eveniet
          corporis nam deleniti? Eum tempora veritatis natus, atque praesentium dolorum, fugit accusantium expedita
          error maxime, odit doloremque soluta explicabo ipsam dolore.</p>
      </div>
    </div>
  </div>
  <Create />
</template>

<style scoped lang="scss">
.choose-section {
  position: absolute;
  top: 40dvh;
  // left: 50%;
  // transform: translate(-50%, -50%);


}

// .position-relative{
//   position: relative;
//   text-align: center;
//   display: flex;
// }</style>
